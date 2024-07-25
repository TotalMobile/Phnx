using System.Net.Http;

namespace Phnx;

/// <summary>
/// Extensions for <see cref="HttpContent"/>
/// </summary>
public static class HttpContentExtensions 
{
    private const string EmptyContentTypeName = "EmptyContent";
    
    /// <summary>
    /// Check for null or empty content.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns>A boolean value indicating if the content is null or empty</returns>
    public static bool IsNullOrEmpty(this HttpContent instance) 
    {
        return instance == null || 
               instance.Headers.ContentLength == 0 || 
               instance.GetType().Name == EmptyContentTypeName;
    }
}