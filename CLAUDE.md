# CLAUDE.md — Gladia SDK

## Overview

Auto-generated C# SDK for [Gladia](https://gladia.io/) — speech-to-text transcription platform supporting 100+ languages.
Covers pre-recorded transcription, live/streaming transcription, file management, and job history.

## Build & Test

```bash
dotnet build Gladia.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with Gladia API key:

```csharp
var client = new GladiaClient(apiKey); // GLADIA_API_KEY env var
```

## Key Files

- `src/libs/Gladia/generate.sh` — Regeneration script (downloads spec, converts apiKey→bearer, runs autosdk)
- `src/libs/Gladia/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- OpenAPI spec: `https://api.gladia.io/openapi.json` (3.1.0)
- Spec uses `apiKey` type in `x-gladia-key` header; `generate.sh` converts to `http/bearer` via `jq`
- MEAI candidate: `ISpeechToTextClient` interface
