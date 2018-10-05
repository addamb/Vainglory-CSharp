using Newtonsoft.Json;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The IncludedData class
    /// Contains the Objects for the Included Node when getting match, included from url.
    /// </summary>
    public class IncludedData
    {
        /// <summary>
        /// Gets or sets Included
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty included</para>
        /// </remarks>
        /// See <see cref="Included"/>
        [JsonProperty("included")]
        Included Included { get; set; }
    }
}