namespace SpritPriceClient.Abstraction.Configuration;

/// <summary>
/// The configuration values of the client. Store these settings in a configuration file that is not part of a repository.
/// Always keep the terms you agreed with when you registered for an API key at Tankerkönig.de in mind. Specifically do
/// *NOT* share your personal API key, and keep in mind that the data you retrieve is shared under CC BY 4.0.
/// </summary>
public class SpritPriceClientConfiguration {
    /// <summary>
    /// The base uri of the Tankerkönig API.
    /// </summary>
    public Uri? BaseApiUri { get; set; }

    /// <summary>
    /// The API key you got when you registered one at https://creativecommons.tankerkoenig.de/.
    /// </summary>
    public string? ApiKey { get; set; }

    /// <summary>
    /// Checks if the settings have been configured.
    /// </summary>
    public bool IsConfigured => BaseApiUri != null && !string.IsNullOrWhiteSpace(ApiKey);
}