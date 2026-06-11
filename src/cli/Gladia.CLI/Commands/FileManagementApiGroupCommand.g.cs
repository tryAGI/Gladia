#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class FileManagementApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"file-management", @"File Management endpoint commands.");
                         command.Subcommands.Add(FileManagementFileControllerUploadV2CommandApiCommand.Create());
        return command;
    }
}