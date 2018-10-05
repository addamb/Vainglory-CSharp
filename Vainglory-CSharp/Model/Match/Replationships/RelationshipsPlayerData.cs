using Newtonsoft.Json;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The RelationshipsPlayerData class
    /// Contains the Objects for the Relationships Player main Node when getting match, included from url.
    /// </summary>
    public class RelationshipsPlayerData
    {
        /// <summary>
        /// Gets or sets RelationshipsPlayer
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty data</para>
        /// </remarks>
        /// See <see cref="RelationshipsPlayer"/>
        [JsonProperty("data")]
        RelationshipsPlayer RelationshipsPlayer { get; set; }
    }
}