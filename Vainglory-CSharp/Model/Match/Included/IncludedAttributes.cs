using Newtonsoft.Json;
using System;
using static Vainglory_CSharp.Model.Match.ShardIdConverter;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The IncludedAttributes class
    /// Contains the Objects for the data under the included, attributes node when getting players from url.
    /// </summary>
    public class IncludedAttributes
    {
        /// <summary>
        /// Gets or sets ShardId
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty shardId</para>
        /// </remarks>
        /// See <see cref="ShardId"/>
        [JsonProperty("shardId", NullValueHandling = NullValueHandling.Ignore)]
        public ShardId ShardId { get; set; }

        /// <summary>
        /// Gets or sets Stats
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty stats</para>
        /// </remarks>
        /// See <see cref="IncludedStats"/>
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public IncludedStats Stats { get; set; }

        /// <summary>
        /// Gets or sets Won
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty won</para>
        /// </remarks>
        /// See <see cref="bool"/>
        [JsonProperty("won", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool? Won { get; set; }

        /// <summary>
        /// Gets or sets Url
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty URL</para>
        /// </remarks>
        /// See <see cref="IncludedStats"/>
        [JsonProperty("URL", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty createdAt</para>
        /// </remarks>
        /// See <see cref="DateTimeOffset"/>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty description</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty name</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets PatchVersion
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty patchVersion</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("patchVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string PatchVersion { get; set; }

        /// <summary>
        /// Gets or sets TitleId
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty titleId</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("titleId", NullValueHandling = NullValueHandling.Ignore)]
        public string TitleId { get; set; }

        /// <summary>
        /// Gets or sets Actor
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty actor</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("actor", NullValueHandling = NullValueHandling.Ignore)]
        public string Actor { get; set; }
    }
}