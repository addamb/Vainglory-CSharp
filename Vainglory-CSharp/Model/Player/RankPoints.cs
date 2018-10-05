using Newtonsoft.Json;

namespace Vainglory_CSharp.Model.Player
{
    /// <summary>
    /// The RankPoints class
    /// Contains the Objects for the data under the rankPoints node when getting players from url.
    /// </summary>
    public class RankPoints
    {
        /// <summary>
        /// Gets or sets Blitz
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty blitz</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("blitz")]
        public long Blitz { get; set; }

        /// <summary>
        /// Gets or sets Ranked
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty ranked</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("ranked")]
        public long Ranked { get; set; }

        /// <summary>
        /// Gets or sets Ranked5v5
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty ranked_5v5</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("ranked_5v5")]
        public long Ranked5V5 { get; set; }
    }
}