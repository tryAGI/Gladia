#!/usr/bin/env bash
set -euo pipefail
readonly openapi_url="https://api.gladia.io/openapi.json"
dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.json

# Gladia spec uses apiKey in x-gladia-key header. Convert to http/bearer for AutoSDK constructor generation.
# Add top-level security array.
jq '
  .components.securitySchemes.ApiKeyAuth = {
    "type": "http",
    "scheme": "bearer"
  } |
  .security = [{"ApiKeyAuth": []}]
' openapi.json > openapi_fixed.json && mv openapi_fixed.json openapi.json

autosdk generate openapi.json \
  --namespace Gladia \
  --clientClassName GladiaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
