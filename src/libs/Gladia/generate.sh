#!/usr/bin/env bash
set -euo pipefail
readonly openapi_url="https://api.gladia.io/openapi.json"
dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.json

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
