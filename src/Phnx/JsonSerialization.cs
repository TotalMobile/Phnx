using System.Text.Json;

namespace Phnx;

/// <summary>
/// Json serializer defaults.
/// </summary>
public static class JsonSerialization {
    /// <summary>
    /// Return default <see cref="JsonSerializerOptions"/>.
    /// </summary>
    public static readonly JsonSerializerOptions DefaultOptions = new() 
    {
        PropertyNameCaseInsensitive = true
    };
}