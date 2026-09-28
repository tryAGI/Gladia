#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class FileManagementApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"file-management", @"File Management endpoint commands.");
                         command.Subcommands.Add(FileManagementFileControllerUploadV2CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}