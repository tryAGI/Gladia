#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class JobHistoryApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"job-history", @"Job History endpoint commands.");
                         command.Subcommands.Add(JobHistoryHistoryControllerGetListV1CommandApiCommand.Create());
        return command;
    }
}