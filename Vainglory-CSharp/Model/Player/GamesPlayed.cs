using Newtonsoft.Json;

namespace Vainglory_CSharp.Model.Player
{
    /// <summary>
    /// The GamesPlayed class
    /// Contains the Objects for the data under the gamesPlayed node when getting players from url.
    /// </summary>
    public class GamesPlayed
    {
        /// <summary>
        /// Gets or sets Aral
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty aral</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("aral")]
        public long Aral { get; set; }

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
        /// Gets or sets BlitzRounds
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty blitz_rounds</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("blitz_rounds")]
        public long BlitzRounds { get; set; }

        /// <summary>
        /// Gets or sets Casual
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty casual</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("casual")]
        public long Casual { get; set; }

        /// <summary>
        /// Gets or sets Casual5v5
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty casual_5v5</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("casual_5v5")]
        public long Casual5V5 { get; set; }

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