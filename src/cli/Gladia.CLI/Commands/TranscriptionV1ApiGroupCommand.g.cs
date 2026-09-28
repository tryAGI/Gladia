#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class TranscriptionV1ApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"transcription-v1", @"Transcription V1 endpoint commands.");
                         command.Subcommands.Add(TranscriptionV1VideoToTextControllerVideoTranscriptionCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}