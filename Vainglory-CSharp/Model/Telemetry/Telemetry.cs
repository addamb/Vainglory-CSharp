using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace Vainglory_CSharp.Model
{
    /// <summary>
    /// The Telemetry class
    /// Contains the Objects for the data when assets id is searched when getting players from url.
    /// </summary>
     public partial class Telemetry
    {
        /// <summary>
        /// Gets or sets Time
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty time</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty type</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Payload
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty payload</para>
        /// </remarks>
        /// See <see cref="Payload"/>
        [JsonProperty("payload")]
        public Payload Payload { get; set; }
    }

    /// <summary>
    /// The Telemetry partial class
    /// Contains the Objects for the data when assets id is searched when getting players from url.
    /// </summary
    public partial class Telemetry
    {
        /// <summary>
        /// FromJson Method
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Deserialized Telemetry Data</returns>
        /// <param name="json">json converted to Telemetry[]</param>
        public static Telemetry[] FromJson(string json) => JsonConvert.DeserializeObject<Telemetry[]>(json, Converter.Settings);
    }

    /// <summary>
    /// The ParseStringConverter internal class
    /// Contains JsonConverter methods.
    /// </summary
    internal class ParseStringConverter : JsonConverter
    {
        /// <summary>
        /// CanConvert Method
        /// </summary>
        /// <param name="t"></param>
        /// <returns>converted long to type</returns>
        /// <param name="t">long converted to type</param>
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
