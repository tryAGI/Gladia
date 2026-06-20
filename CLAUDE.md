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

API key auth with Gladia's `x-gladia-key` header:

```csharp
var client = new GladiaClient(apiKey); // GLADIA_API_KEY env var
```

## Key Files

- `src/libs/Gladia/generate.sh` — Regeneration script (downloads spec, runs autosdk with `--security-scheme ApiKey:Header:x-gladia-key`)
- `src/libs/Gladia/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with `x-gladia-key` auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- OpenAPI spec: `https://api.gladia.io/openapi.json` (3.1.0)
- Spec uses `apiKey` type in `x-gladia-key` header; `--security-scheme ApiKey:Header:x-gladia-key` preserves the documented header at generation time
- MEAI: `ISpeechToTextClient` implemented in `Extensions/GladiaClient.SpeechToTextClient.cs`
  - Uploads audio stream via `/v2/upload`, initiates job via `/v2/pre-recorded`, polls until done
  - Maps `SpeechLanguage` to `TranscriptionLanguageCodeEnum` via `LanguageConfig`
  - Supports `RawRepresentationFactory` for pre-built `InitTranscriptionRequest`
- `generate.sh` patches current spec gaps for `InitTranscriptionRequest.model` / Solaria-3 and optional `post_session_metadata`
