#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class OpenRouterApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"open-router", @"OpenRouter endpoint commands.");
                         command.Subcommands.Add(OpenRouterModelsControllerListV1CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}