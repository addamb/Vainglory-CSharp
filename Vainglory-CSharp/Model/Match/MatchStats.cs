using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The MatchStats class
    /// Contains the Objects for the data under the stats node when getting players from url.
    /// </summary>
    public class MatchStats
    {
        /// <summary>
        /// Gets or sets EndGameReason
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty endGameReason</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("endGameReason")]
        public string EndGameReason { get; set; }

        /// <summary>
        /// Gets or sets Queue
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty queue</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// GetEndGameReason
        /// </summary>
        /// <remarks>
        /// <para>Gets End Game Reason </para>
        /// </remarks>
        /// <returns>Match End Game Reason</returns>
        public string GetEndGameReason() => EndGameReason;

        /// <summary>
        /// GetQueue
        /// </summary>
        /// <remarks>
        /// <para>Gets Match Queue</para>
        /// </remarks>
        /// <returns>Match Queue</returns>
        public string GetQueue() => Queue;
    }
}
