#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Gladia
{
    /// <summary>
    /// Example: {"id":"45463597-20b7-4af7-b3b3-f5fb778203ab","request_id":"G-45463597","version":2,"kind":"pre-recorded","created_at":"2023-12-28T09:04:17.210Z","status":"queued","file":{"id":"f0dcZE10-23d8-47f0-a25d-74a6eed88721","filename":"split_infinity.wav","source":"http://files.gladia.io/example/audio-transcription/split_infinity.wav","audio_duration":20,"number_of_channels":1},"request_params":{"audio_url":"http://files.gladia.io/example/audio-transcription/split_infinity.wav","subtitles":false,"diarization":false,"translation":false,"summarization":false,"sentences":false,"moderation":false,"named_entity_recognition":false,"name_consistency":false,"custom_spelling":false,"structured_data_extraction":false,"chapterization":false,"sentiment_analysis":false,"display_mode":false,"audio_enhancer":false,"language_config":{"code_switching":false,"languages":["fr","en"]},"accurate_words_timestamps":false,"diarization_enhanced":false,"punctuation_enhanced":false},"completed_at":null,"custom_metadata":null,"error_code":null,"result":null}
    /// </summary>
    public readonly partial struct TranscriptionControllerGetTranscriptV2Response : global::System.IEquatable<TranscriptionControllerGetTranscriptV2Response>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind? Kind { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Gladia.PreRecordedResponse? PreRecorded { get; init; }
#else
        public global::Gladia.PreRecordedResponse? PreRecorded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreRecorded))]
#endif
        public bool IsPreRecorded => PreRecorded != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Gladia.StreamingResponse? Live { get; init; }
#else
        public global::Gladia.StreamingResponse? Live { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Live))]
#endif
        public bool IsLive => Live != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptionControllerGetTranscriptV2Response(global::Gladia.PreRecordedResponse value) => new TranscriptionControllerGetTranscriptV2Response((global::Gladia.PreRecordedResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Gladia.PreRecordedResponse?(TranscriptionControllerGetTranscriptV2Response @this) => @this.PreRecorded;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionControllerGetTranscriptV2Response(global::Gladia.PreRecordedResponse? value)
        {
            PreRecorded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptionControllerGetTranscriptV2Response(global::Gladia.StreamingResponse value) => new TranscriptionControllerGetTranscriptV2Response((global::Gladia.StreamingResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Gladia.StreamingResponse?(TranscriptionControllerGetTranscriptV2Response @this) => @this.Live;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionControllerGetTranscriptV2Response(global::Gladia.StreamingResponse? value)
        {
            Live = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionControllerGetTranscriptV2Response(
            global::Gladia.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind? kind,
            global::Gladia.PreRecordedResponse? preRecorded,
            global::Gladia.StreamingResponse? live
            )
        {
            Kind = kind;

            PreRecorded = preRecorded;
            Live = live;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Live as object ??
            PreRecorded as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PreRecorded?.ToString() ??
            Live?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPreRecorded && !IsLive || !IsPreRecorded && IsLive;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Gladia.PreRecordedResponse?, TResult>? preRecorded = null,
            global::System.Func<global::Gladia.StreamingResponse?, TResult>? live = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreRecorded && preRecorded != null)
            {
                return preRecorded(PreRecorded!);
            }
            else if (IsLive && live != null)
            {
                return live(Live!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Gladia.PreRecordedResponse?>? preRecorded = null,
            global::System.Action<global::Gladia.StreamingResponse?>? live = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreRecorded)
            {
                preRecorded?.Invoke(PreRecorded!);
            }
            else if (IsLive)
            {
                live?.Invoke(Live!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PreRecorded,
                typeof(global::Gladia.PreRecordedResponse),
                Live,
                typeof(global::Gladia.StreamingResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TranscriptionControllerGetTranscriptV2Response other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Gladia.PreRecordedResponse?>.Default.Equals(PreRecorded, other.PreRecorded) &&
                global::System.Collections.Generic.EqualityComparer<global::Gladia.StreamingResponse?>.Default.Equals(Live, other.Live) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranscriptionControllerGetTranscriptV2Response obj1, TranscriptionControllerGetTranscriptV2Response obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptionControllerGetTranscriptV2Response>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranscriptionControllerGetTranscriptV2Response obj1, TranscriptionControllerGetTranscriptV2Response obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptionControllerGetTranscriptV2Response o && Equals(o);
        }
    }
}
