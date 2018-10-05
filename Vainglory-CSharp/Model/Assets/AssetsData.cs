using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vainglory_CSharp.Model
{
    /// <summary>
    /// The AssetsData class
    /// Contains the Objects for the Assets Node.
    /// </summary>
    /// <remarks>
    /// <para>Used by the PlayerRelationships <see cref="PlayerRelationships"/> and Match <see cref="Match"/></para>
    /// </remarks>
    public class AssetsData
    {
        /// <summary>
        /// Gets or sets Data
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty data</para>
        /// </remarks>
        /// See <see cref="object"/>
        [JsonProperty("data")]
        public Assets[] Data { get; set; }
    }
}
