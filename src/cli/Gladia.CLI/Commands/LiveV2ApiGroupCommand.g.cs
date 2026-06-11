#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class LiveV2ApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"live-v2", @"Live V2 endpoint commands.");
                         command.Subcommands.Add(LiveV2StreamingControllerDeleteStreamingJobV2CommandApiCommand.Create());
                         command.Subcommands.Add(LiveV2StreamingControllerGetAudioV2CommandApiCommand.Create());
                         command.Subcommands.Add(LiveV2StreamingControllerGetStreamingJobV2CommandApiCommand.Create());
                         command.Subcommands.Add(LiveV2StreamingControllerGetStreamingJobsV2CommandApiCommand.Create());
                         command.Subcommands.Add(LiveV2StreamingControllerInitStreamingSessionV2CommandApiCommand.Create());
                         command.Subcommands.Add(LiveV2StreamingControllerPatchRequestParamsV2CommandApiCommand.Create());
        return command;
    }
}