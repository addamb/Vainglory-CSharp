using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model.Player
{
    /// <summary>
    /// The Player class
    /// Contains the Objects for the data under the first node when getting players from url.
    /// </summary>
    public class Player
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
        /// <para>Set from JsonProperty attribtes</para>
        /// </remarks>
        /// See <see cref="PlayerAttributes"/>
        [JsonProperty("attributes")]
        public PlayerAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets Relationships
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty relationships</para>
        /// </remarks>
        /// See <see cref="PlayerRelationships"/>
        [JsonProperty("relationships")]
        public PlayerRelationships Relationships { get; set; }

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
        /// GetId
        /// </summary>
        /// <remarks>
        /// <para>Gets Guid ID</para>
        /// </remarks>
        /// <returns>Guid ToString</returns>
        public string GetId() => Id.ToString();
    }
}
