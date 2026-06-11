#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class PreRecordedV2ApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"pre-recorded-v2", @"Pre-recorded V2 endpoint commands.");
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerDeletePreRecordedJobV2CommandApiCommand.Create());
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerGetAudioV2CommandApiCommand.Create());
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerGetPreRecordedJobV2CommandApiCommand.Create());
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerGetPreRecordedJobsV2CommandApiCommand.Create());
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerInitPreRecordedJobV2CommandApiCommand.Create());
        return command;
    }
}