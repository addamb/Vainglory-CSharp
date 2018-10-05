using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model
{
    /// <summary>
    /// The Assets class
    /// Contains the Objects for the Assets Node.
    /// </summary>
    /// <remarks>
    /// <para>Used by the PlayerRelationships <see cref="PlayerRelationships"/> and Match <see cref="Match"/></para>
    /// </remarks>
    public class Assets
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
