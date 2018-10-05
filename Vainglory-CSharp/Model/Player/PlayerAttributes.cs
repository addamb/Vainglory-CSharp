using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model.Player
{
    /// <summary>
    /// The PlayerAttributes class
    /// Contains the Objects for the data under the attributes node when getting players from url.
    /// </summary>
    public class PlayerAttributes
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
        /// Gets or sets Name
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty name</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("name")]
        public string Name { get; set; }

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
        /// See <see cref="string"/>
        [JsonProperty("shardId")]
        public string ShardId { get; set; }

        /// <summary>
        /// Gets or sets Stats
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty stats</para>
        /// </remarks>
        /// See <see cref="PlayerStats"/>
        [JsonProperty("stats")]
        public PlayerStats Stats { get; set; }

        /// <summary>
        /// Gets or sets TitleId
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty titleId</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("titleId")]
        public string TitleId { get; set; }

        /// <summary>
        /// GetName
        /// </summary>
        /// <remarks>
        /// <para>Gets Get of Player</para>
        /// </remarks>
        /// <returns>Player Name</returns>
        public string GetName() => Name;

        /// <summary>
        /// GetPlayerStats
        /// </summary>
        /// <remarks>
        /// <para>Gets Player Stats</para>
        /// </remarks>
        /// <returns>Player stats</returns>
        public PlayerStats GetPlayerStats() => Stats;
    }
}