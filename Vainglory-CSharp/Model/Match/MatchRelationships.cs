using Newtonsoft.Json;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The MatchRelationships class
    /// Contains the Objects for the data under the relationships node when getting players from url.
    /// </summary>
    public class MatchRelationships
    {
        /// <summary>
        /// Gets or sets Assets
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty assets</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("assets")]
        public AssetsData Assets { get; set; }

        /// <summary>
        /// Gets or sets Rosters
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty rosters</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("rosters")]
        public AssetsData Rosters { get; set; }

        /// <summary>
        /// Gets or sets Rounds
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty rounds</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("rounds")]
        public AssetsData Rounds { get; set; }

        /// <summary>
        /// Gets or sets Spectators
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty spectators</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("spectators")]
        public AssetsData Spectators { get; set; }
    }
}