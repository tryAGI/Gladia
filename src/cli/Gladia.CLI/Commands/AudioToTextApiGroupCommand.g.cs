#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class AudioToTextApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"audio-to-text", @"AudioToText endpoint commands.");
                         command.Subcommands.Add(AudioToTextAudioToTextControllerAudioTranscriptionCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}