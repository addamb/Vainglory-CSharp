using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The Included class
    /// Contains the Objects for the data under the included node when getting players from url.
    /// </summary>
    public class Included
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

        /// <summary>
        /// Gets or sets Attributes
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty attributes</para>
        /// </remarks>
        /// See <see cref="IncludedAttributes"/>
        [JsonProperty("attributes")]
        public IncludedAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets Relationships
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty relationships</para>
        /// </remarks>
        /// See <see cref="IncludedRelationships"/>
        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore)]
        public IncludedRelationships Relationships { get; set; }

        /// <summary>
        /// Gets or sets MatchLinks
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty links</para>
        /// </remarks>
        /// See <see cref="MatchLinks"/>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public MatchLinks Links { get; set; }
    }
}