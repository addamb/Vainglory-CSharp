using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Vainglory_CSharp.Model.Status
{
    /// <summary>
    /// The StatusData patial class
    /// Contains the Objects for the main data node when getting staus from url.
    /// </summary>
    public partial class StatusData
    {
        /// <summary>
        /// Gets or sets Status
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty data</para>
        /// </remarks>
        /// See <see cref="Status"/>
        [JsonProperty("data")]
        public Status Status { get; set; }
    }

    /// <summary>
    /// The Second StatusData patial class
    /// </summary>
    /// <remarks>
    /// <para>Contains the FromJson Method </para>
    /// </remarks>
    public partial class StatusData
    {
        /// <summary>
        /// FromJson Method
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Deserialized StatusData</returns>
        /// <param name="json">json converted to string</param>
        public static StatusData FromJson(string json) => JsonConvert.DeserializeObject<StatusData>(json, Converter.Settings);
    }

    /// <summary>
    /// Internal Converter Class
    /// </summary>
    /// <remarks>
    /// <para>Used to set the JsonSerializerSettings when JsonConvert.DeserializeObject<StatusData> is used.</para>
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
