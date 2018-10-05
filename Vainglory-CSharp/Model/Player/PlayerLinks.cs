using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model.Player
{
    /// <summary>
    /// The PlayerLink class
    /// Contains the Objects for the data under the links node when getting players from url.
    /// </summary>
    public class PlayerLinks
    {
        /// <summary>
        /// Gets or sets Schema
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty schema</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("schema")]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets Self
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty self</para>
        /// </remarks>
        /// See <see cref="Uri"/>
        [JsonProperty("self")]
        public Uri Self { get; set; }
    }
}