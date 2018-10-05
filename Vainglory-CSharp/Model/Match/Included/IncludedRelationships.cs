using Newtonsoft.Json;
using Vainglory_CSharp.Model.Player;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The IncludedRelationships class
    /// Contains the Objects for the Included relationships Node when getting match, included from url.
    /// </summary>
    public class IncludedRelationships
    {
        /// <summary>
        /// Gets or sets Participants
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty participants</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public Assets Participants { get; set; }

        /// <summary>
        /// Gets or sets Team
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty team</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("team", NullValueHandling = NullValueHandling.Ignore)]
        public Assets Team { get; set; }

        /// <summary>
        /// Gets or sets Assets
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty assets</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
        public Assets Assets { get; set; }

        /// <summary>
        /// Gets or sets RelationshipsPlayerData
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty player</para>
        /// </remarks>
        /// See <see cref="Assets"/>
        [JsonProperty("player", NullValueHandling = NullValueHandling.Ignore)]
        public RelationshipsPlayerData RelationshipsPlayerData { get; set; }
    }
}