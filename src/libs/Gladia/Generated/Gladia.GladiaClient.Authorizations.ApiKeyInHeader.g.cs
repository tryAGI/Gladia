
#nullable enable

namespace Gladia
{
    public sealed partial class GladiaClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "x-gladia-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Gladia.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyXGladiaKey",
                Location = "Header",
                Name = "x-gladia-key",
                Value = apiKey,
            });
        }
    }
}