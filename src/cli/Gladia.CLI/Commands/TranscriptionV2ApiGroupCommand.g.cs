#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class TranscriptionV2ApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"transcription-v2", @"Transcription V2 endpoint commands.");
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerDeleteTranscriptV2CommandApiCommand.Create());
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerGetAudioV2CommandApiCommand.Create());
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerGetTranscriptV2CommandApiCommand.Create());
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerInitPreRecordedJobV2CommandApiCommand.Create());
                         command.Subcommands.Add(TranscriptionV2TranscriptionControllerListV2CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}