#nullable enable

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static class OpenRouterApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"open-router", @"OpenRouter endpoint commands.");
                         command.Subcommands.Add(OpenRouterModelsControllerListV1CommandApiCommand.Create());
        return command;
    }
}