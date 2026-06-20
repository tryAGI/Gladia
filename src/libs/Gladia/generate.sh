#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://api.gladia.io/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error --location https://api.gladia.io/openapi.json -o openapi.json

# Fix 1: Normalize dynamic timestamp examples to a fixed value to prevent noise diffs.
# Fix 2: Add pre-recorded transcription model support documented by Gladia but missing from the OpenAPI spec.
# Fix 3: post_session_metadata is omitted by list responses even though the spec marks it required.
# Fix 4: AudioUploadMetadataDTO.extension is a file extension string, not a uuid.
jq '
  (.. | objects | select(.example? and (.example | type == "string") and (.example | test("^\\d{4}-\\d{2}-\\d{2}T\\d{2}:\\d{2}:\\d{2}\\.\\d+Z$")))) .example |= "2024-01-01T00:00:00.000Z"
  | .components.schemas.PreRecordedTranscriptionModel = {
      "type": "string",
      "description": "The model used for async pre-recorded transcription.",
      "enum": [
        "solaria-1",
        "solaria-3"
      ],
      "default": "solaria-1"
    }
  | .components.schemas.InitTranscriptionRequest.properties.model = {
      "description": "The model used to process the audio. \"solaria-1\" is used by default. \"solaria-3\" is async pre-recorded only and requires exactly one language in language_config.languages.",
      "default": "solaria-1",
      "allOf": [
        {
          "$ref": "#/components/schemas/PreRecordedTranscriptionModel"
        }
      ]
    }
  | .components.schemas.PreRecordedRequestParamsResponse.properties.model = {
      "description": "The model used to process the audio.",
      "allOf": [
        {
          "$ref": "#/components/schemas/PreRecordedTranscriptionModel"
        }
      ]
    }
  | del(.components.schemas.AudioUploadMetadataDTO.properties.extension.format)
  | .components.schemas.PreRecordedResponse.required |= map(select(. != "post_session_metadata"))
  | .components.schemas.StreamingResponse.required |= map(select(. != "post_session_metadata"))
' openapi.json > openapi_fixed.json && mv openapi_fixed.json openapi.json

# Auth: --security-scheme normalizes Gladia's apiKey auth to the documented x-gladia-key header.
autosdk generate openapi.json \
  --namespace Gladia \
  --clientClassName GladiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:x-gladia-key

rm -rf ../../cli/Gladia.CLI

autosdk cli-project openapi.json \
  --output ../../cli/Gladia.CLI \
  --sdk-project ../../libs/Gladia/Gladia.csproj \
  --targetFramework net10.0 \
  --namespace Gladia \
  --clientClassName GladiaClient \
  --package-id Gladia.CLI \
  --tool-command-name gladia \
  --user-secrets-id Gladia.CLI \
  --api-key-env-var GLADIA_API_KEY \
  --base-url-env-var GLADIA_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:x-gladia-key
