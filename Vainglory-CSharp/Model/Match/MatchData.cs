using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;
using Vainglory_CSharp.Model.Player;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The MatchData class
    /// Contains the Objects for the main data Node when getting match from url.
    /// </summary>
    partial class MatchData
    {
        /// <summary>
        /// Gets or sets Match
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty data</para>
        /// </remarks>
        /// See <see cref="Match.Match"/>
        [JsonProperty("data")]
        public Match Match { get; set; }

        /// <summary>
        /// Gets or sets Included
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty included</para>
        /// </remarks>
        /// See <see cref="Included"/>
        [JsonProperty("included")]
        public Included[] Included { get; set; }

        /// <summary>
        /// Gets or sets Links
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty links</para>
        /// </remarks>
        /// See <see cref="MatchLinks"/>
        [JsonProperty("links")]
        public MatchLinks Links { get; set; }

        /// <summary>
        /// Gets or sets Meta
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty meta</para>
        /// </remarks>
        /// See <see cref="Player.Meta"/>
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    /// <summary>
    /// The Second MatchData patial class
    /// </summary>
    /// <remarks>
    /// <para>Contains the FromJson Method </para>
    /// </remarks>
    public partial class MatchData
    {
        /// <summary>
        /// FromJson Method
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Deserialized MatchData</returns>
        /// <param name="json">json converted to string</param>
        public static MatchData FromJson(string json) => JsonConvert.DeserializeObject<MatchData>(json, Converter.Settings);
    }

    /// <summary>
    /// Internal Converter Class
    /// </summary>
    /// <remarks>
    /// <para>Used to set the JsonSerializerSettings when JsonConvert.DeserializeObject<MatchData> is used.</para>
    /// </remarks>
    internal static class Converter
    {
        /// <summary>
        /// JsonSerializerSettings readonly Method
        /// </summary>
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                ShardIdConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    /// <summary>
    /// Internal ShardIdConverter Class
    /// </summary>
    /// <remarks>
    /// <para>Used to convert ShardId</para>
    /// </remarks>
    internal class ShardIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ShardId) || t == typeof(ShardId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);

            return TranslateEnum(value);
            //if (value == "na")
            //{
            //    return ShardId.NA;
            //}
            throw new Exception("Cannot unmarshal type ShardId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ShardId)untypedValue;
            if (value == ShardId.NA)
            {
                serializer.Serialize(writer, "na");
                return;
            }
            throw new Exception("Cannot marshal type ShardId");
        }

        internal class ParseStringConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                bool b;
                if (Boolean.TryParse(value, out b))
                {
                    return b;
                }
                throw new Exception("Cannot unmarshal type bool");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (bool)untypedValue;
                var boolString = value ? "true" : "false";
                serializer.Serialize(writer, boolString);
                return;
            }

            public static readonly ParseStringConverter Singleton = new ParseStringConverter();
        }

        public static readonly ShardIdConverter Singleton = new ShardIdConverter();

        public ShardId TranslateEnum(string id)
        {
            switch (id)
            {
                case "cn":
                    return ShardId.CN;
                case "na":
                    return ShardId.NA;
                case "eu":
                    return ShardId.EU;
                case "sa":
                    return ShardId.SA;
                case "ea":
                    return ShardId.EA;
                case "sg":
                    return ShardId.SG;
                default:
                    return ShardId.NA;
            }
        }
    }
}
