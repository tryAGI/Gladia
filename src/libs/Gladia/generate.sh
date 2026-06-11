#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.gladia.io/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://api.gladia.io/openapi.json -o openapi.json

# Fix 1: Normalize dynamic timestamp examples to a fixed value to prevent noise diffs.
jq '
  (.. | objects | select(.example? and (.example | type == "string") and (.example | test("^\\d{4}-\\d{2}-\\d{2}T\\d{2}:\\d{2}:\\d{2}\\.\\d+Z$")))) .example |= "2024-01-01T00:00:00.000Z"
' openapi.json > openapi_fixed.json && mv openapi_fixed.json openapi.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.json \
  --namespace Gladia \
  --clientClassName GladiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

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
  --security-scheme Http:Header:Bearer
