using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The RelationshipsPlayer class
    /// Contains the Objects for the Relationships player Node when getting match, included from url.
    /// </summary>
    public class RelationshipsPlayer
    {
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
        /// Gets or sets Id
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty id</para>
        /// </remarks>
        /// See <see cref="Guid"/>
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}