#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Gladia.CLI.Commands;

internal static partial class TranscriptionV2TranscriptionControllerListV2CommandApiCommand
{
    private static Option<int?> Offset { get; } = new(
        name: @"--offset")
    {
        Description = @"The starting point for pagination. A value of 0 starts from the first item.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The maximum number of items to return. Useful for pagination and controlling data payload size.",
    };

    private static Option<global::System.DateTime?> Date { get; } = new(
        name: @"--date")
    {
        Description = @"Filter items relevant to a specific date in ISO format (YYYY-MM-DD).",
    };

    private static Option<global::System.DateTime?> BeforeDate { get; } = new(
        name: @"--before-date")
    {
        Description = @"Include items that occurred before the specified date in ISO format.",
    };

    private static Option<global::System.DateTime?> AfterDate { get; } = new(
        name: @"--after-date")
    {
        Description = @"Filter for items after the specified date. Use with `before_date` for a range. Date in ISO format.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2Statu>?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter the list based on item status. Accepts multiple values from the predefined list.",
    };

    private static Option<object?> CustomMetadata { get; } = new(
        name: @"--custom-metadata")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::Gladia.TranscriptionControllerListV2KindItem>?> Kind { get; } = new(
        name: @"--kind")
    {
        Description = @"Filter the list based on the item type. Supports multiple values from the predefined list.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Gladia.ListTranscriptionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Gladia.ListTranscriptionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"transcription-controller-list-v2", @"Get transcription jobs based on query parameters");
                        command.Options.Add(Offset);
                        command.Options.Add(Limit);
                        command.Options.Add(Date);
                        command.Options.Add(BeforeDate);
                        command.Options.Add(AfterDate);
                        command.Options.Add(Status);
                        command.Options.Add(CustomMetadata);
                        command.Options.Add(Kind);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var offset = parseResult.GetValue(Offset);
                        var limit = parseResult.GetValue(Limit);
                        var date = parseResult.GetValue(Date);
                        var beforeDate = parseResult.GetValue(BeforeDate);
                        var afterDate = parseResult.GetValue(AfterDate);
                        var status = parseResult.GetValue(Status);
                        var customMetadata = parseResult.GetValue(CustomMetadata);
                        var kind = parseResult.GetValue(Kind);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.TranscriptionV2.TranscriptionControllerListV2Async(
                                    offset: offset,
                                    limit: limit,
                                    date: date,
                                    beforeDate: beforeDate,
                                    afterDate: afterDate,
                                    status: status,
                                    customMetadata: customMetadata,
                                    kind: kind,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Gladia.SourceGenerationContext.Default,
                                        @"Items",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Gladia.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}