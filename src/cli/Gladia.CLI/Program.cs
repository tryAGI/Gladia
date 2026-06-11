#nullable enable

using System.CommandLine;
using Gladia.CLI;
using Gladia.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the Gladia SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(AudioToTextApiGroupCommand.Create());
rootCommand.Subcommands.Add(FileManagementApiGroupCommand.Create());
rootCommand.Subcommands.Add(JobHistoryApiGroupCommand.Create());
rootCommand.Subcommands.Add(LiveV2ApiGroupCommand.Create());
rootCommand.Subcommands.Add(OpenRouterApiGroupCommand.Create());
rootCommand.Subcommands.Add(PreRecordedV2ApiGroupCommand.Create());
rootCommand.Subcommands.Add(TranscriptionV1ApiGroupCommand.Create());
rootCommand.Subcommands.Add(TranscriptionV2ApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);