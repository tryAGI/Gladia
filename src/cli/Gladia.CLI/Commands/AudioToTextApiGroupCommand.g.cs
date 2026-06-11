#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class AudioToTextApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"audio-to-text", @"AudioToText endpoint commands.");
                         command.Subcommands.Add(AudioToTextAudioToTextControllerAudioTranscriptionCommandApiCommand.Create());
        return command;
    }
}