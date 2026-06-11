#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class TranscriptionV1ApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"transcription-v1", @"Transcription V1 endpoint commands.");
                         command.Subcommands.Add(TranscriptionV1VideoToTextControllerVideoTranscriptionCommandApiCommand.Create());
        return command;
    }
}