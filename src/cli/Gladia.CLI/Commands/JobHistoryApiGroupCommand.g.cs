#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class JobHistoryApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"job-history", @"Job History endpoint commands.");
                         command.Subcommands.Add(JobHistoryHistoryControllerGetListV1CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}