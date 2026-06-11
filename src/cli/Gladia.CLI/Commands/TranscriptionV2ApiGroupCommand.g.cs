#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class TranscriptionV2ApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"transcription-v2", @"Transcription V2 endpoint commands.");
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerDeleteTranscriptV2CommandApiCommand.Create());
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerGetAudioV2CommandApiCommand.Create());
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerGetTranscriptV2CommandApiCommand.Create());
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerInitPreRecordedJobV2CommandApiCommand.Create());
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerListV2CommandApiCommand.Create());
        return command;
    }
}