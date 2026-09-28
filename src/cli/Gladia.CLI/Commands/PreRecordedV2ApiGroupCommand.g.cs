#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class PreRecordedV2ApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"pre-recorded-v2", @"Pre-recorded V2 endpoint commands.");
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerDeletePreRecordedJobV2CommandApiCommand.Create());
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerGetAudioV2CommandApiCommand.Create());
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerGetPreRecordedJobV2CommandApiCommand.Create());
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerGetPreRecordedJobsV2CommandApiCommand.Create());
                         command.Subcommands.Add(PreRecordedV2PreRecordedControllerInitPreRecordedJobV2CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}