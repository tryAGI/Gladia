#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AudioToTextApiGroupCommand.Create());
                         command.Subcommands.Add(FileManagementApiGroupCommand.Create());
                         command.Subcommands.Add(JobHistoryApiGroupCommand.Create());
                         command.Subcommands.Add(LiveV2ApiGroupCommand.Create());
                         command.Subcommands.Add(OpenRouterApiGroupCommand.Create());
                         command.Subcommands.Add(PreRecordedV2ApiGroupCommand.Create());
                         command.Subcommands.Add(TranscriptionV1ApiGroupCommand.Create());
                         command.Subcommands.Add(TranscriptionV2ApiGroupCommand.Create());
        return command;
    }
}