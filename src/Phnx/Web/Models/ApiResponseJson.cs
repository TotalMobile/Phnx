using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Phnx.Web.Models
{
    /// <summary>
    /// Represents an <see cref="ApiResponse"/> with a JSON format body content
    /// </summary>
    /// <typeparam name="T">The type of data in the JSON body</typeparam>
    public class ApiResponseJson<T> : ApiResponse
    {
        /// <summary>
        /// Create a <see cref="ApiResponseJson{T}"/> from a <see cref="HttpResponseMessage"/>
        /// </summary>
        /// <param name="message">The message to create the response from</param>
        public ApiResponseJson(HttpResponseMessage message) : base(message)
        {
        }

        /// <summary>
        /// Load and deserialize the body to <typeparamref name="T"/>
        /// </summary>
        /// <exception cref="InvalidOperationException">The response, or the body of the response was <see langword="null"/>, or the body of the response was empty</exception>
        /// <exception cref="JsonException">The API response or content is not valid JSON</exception>
        public async Task<T> GetBodyAsync(JsonSerializerOptions options = null) {
            if (Message is null)
            {
                throw new InvalidOperationException($"{nameof(Message)} cannot be null");
            }

            await using var contentStream = await Message.Content.ReadAsStreamAsync();
            var content = await JsonSerializer.DeserializeAsync<T>(contentStream,
                options ?? JsonSerialization.DefaultOptions);
            
            return content;
        }
    }
}