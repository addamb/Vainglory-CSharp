using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The MatchAttributes class
    /// Contains the Objects for the data under the attributes node when getting players from url.
    /// </summary>
    public class MatchAttributes
    {
        /// <summary>
        /// Gets or sets CreatedAt
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty createdAt</para>
        /// </remarks>
        /// See <see cref="DateTimeOffset"/>
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets Duration
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty duration</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// Gets or sets GameMode
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty gameMode</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        /// <summary>
        /// Gets or sets PatchVersion
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty patchVersion</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("patchVersion")]
        public string PatchVersion { get; set; }

        /// <summary>
        /// Gets or sets ShardId
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty shardId</para>
        /// </remarks>
        /// See <see cref="ShardId"/>
        [JsonProperty("shardId")]
        public ShardId ShardId { get; set; }

        /// <summary>
        /// Gets or sets Stats
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty stats</para>
        /// </remarks>
        /// See <see cref="MatchStats"/>
        [JsonProperty("stats")]
        public MatchStats Stats { get; set; }

        /// <summary>
        /// Gets or sets Tags
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty tags</para>
        /// </remarks>
        /// See <see cref="object"/>
        [JsonProperty("tags")]
        public object Tags { get; set; }

        /// <summary>
        /// Gets or sets TitleId
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty titleId</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("titleId")]
        public string TitleId { get; set; }
    }
}