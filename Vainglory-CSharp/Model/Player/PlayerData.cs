using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;

namespace Vainglory_CSharp.Model.Player
{
    /// <summary>
    /// The PlayerData patial class
    /// Contains the Objects for the main data Node when getting players from url.
    /// </summary>
    public partial class PlayerData
    {
        /// <summary>
        /// Gets or sets Player
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty data</para>
        /// </remarks>
        /// See <see cref="Player.Player"/>
        [JsonProperty("data")]
        public Player[] Player { get; set; }

        /// <summary>
        /// Gets or sets Links
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty links</para>
        /// </remarks>
        /// See <see cref="PlayerLinks"/>
        [JsonProperty("links")]
        public PlayerLinks Links { get; set; }

        /// <summary>
        /// Gets or sets Mets
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty meta</para>
        /// </remarks>
        /// See <see cref="Meta"/>
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    /// <summary>
    /// The Second PlayerData patial class
    /// </summary>
    /// <remarks>
    /// <para>Contains the FromJson Method </para>
    /// </remarks>
    public partial class PlayerData
    {
        /// <summary>
        /// FromJson Method
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Deserialized PlayerData</returns>
        /// <param name="json">json converted to string</param>
        public static PlayerData FromJson(string json) => JsonConvert.DeserializeObject<PlayerData>(json, Converter.Settings);
    }

    /// <summary>
    /// Internal Converter Class
    /// </summary>
    /// <remarks>
    /// <para>Used to set the JsonSerializerSettings when JsonConvert.DeserializeObject<PlayerData> is used.</para>
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
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
