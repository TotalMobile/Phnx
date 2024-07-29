using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Phnx;

/// <summary>
/// <see href="https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/converters-how-to?pivots=dotnet-8-0#deserialize-inferred-types-to-object-properties">Infer</see> the CLR type when deserializing a property of type object.
/// </summary>
public class InferredTypeJsonConverter: JsonConverter<object>
{
    public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
          // attempt to parse the string as a datetime...
          JsonTokenType.String when reader.TryGetDateTime(out var value) => value,
          JsonTokenType.String => reader.GetString(),
          // numbers without a decimal to long...
          JsonTokenType.Number when reader.TryGetInt64(out var value) => value,
          // numbers with a decimal to double...
          JsonTokenType.Number => reader.GetDouble(),
          JsonTokenType.True => true,
          JsonTokenType.False => false,
          _ => JsonDocument.ParseValue(ref reader).RootElement.Clone()
        };
    }
    
    public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
