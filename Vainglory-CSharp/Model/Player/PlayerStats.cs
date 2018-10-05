using Newtonsoft.Json;

namespace Vainglory_CSharp.Model.Player
{
    /// <summary>
    /// The PlayerStats class
    /// Contains the Objects for the data under the stats node when getting players from url.
    /// </summary>
    public class PlayerStats
    {
        /// <summary>
        /// Gets or sets EloEarnedSeason4
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_4</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("elo_earned_season_4")]
        public long EloEarnedSeason4 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason5
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_5</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("elo_earned_season_5")]
        public long EloEarnedSeason5 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason6
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_6</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("elo_earned_season_6")]
        public long EloEarnedSeason6 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason7
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_7</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("elo_earned_season_7")]
        public long EloEarnedSeason7 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason8
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_8</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("elo_earned_season_8")]
        public long EloEarnedSeason8 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason9
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_9</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("elo_earned_season_9")]
        public long EloEarnedSeason9 { get; set; }

        /// <summary>
        /// Gets or sets GamesPlayed
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty gamesPlayed</para>
        /// </remarks>
        /// See <see cref="GamesPlayed"/>
        [JsonProperty("gamesPlayed")]
        public GamesPlayed GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets GuildTag
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty guildTag</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("guildTag")]
        public string GuildTag { get; set; }

        /// <summary>
        /// Gets or sets KarmaLevel
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty karmaLevel</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("karmaLevel")]
        public long KarmaLevel { get; set; }

        /// <summary>
        /// Gets or sets Level
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty level</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// Gets or sets LifetimeGold
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty lifetimeGold</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("lifetimeGold")]
        public long LifetimeGold { get; set; }

        /// <summary>
        /// Gets or sets LossStreak
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty lossStreak</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("lossStreak")]
        public long LossStreak { get; set; }

        /// <summary>
        /// Gets or sets Played
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("played")]
        public long Played { get; set; }

        /// <summary>
        /// Gets or sets PlayedAral
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played_aral</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("played_aral")]
        public long PlayedAral { get; set; }

        /// <summary>
        /// Gets or sets PlayedBlitz
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played_blitz</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("played_blitz")]
        public long PlayedBlitz { get; set; }

        /// <summary>
        /// Gets or sets PlayedCasual
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played_casual</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("played_casual")]
        public long PlayedCasual { get; set; }

        /// <summary>
        /// Gets or sets PlayedRanked
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played_ranked</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("played_ranked")]
        public long PlayedRanked { get; set; }

        /// <summary>
        /// Gets or sets RankPoints
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty rankPoints</para>
        /// </remarks>
        /// See <see cref="RankPoints"/>
        [JsonProperty("rankPoints")]
        public RankPoints RankPoints { get; set; }

        /// <summary>
        /// Gets or sets SkillTier
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty skillTier</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("skillTier")]
        public long SkillTier { get; set; }

        /// <summary>
        /// Gets or sets WinStreak
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty winStreak</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("winStreak")]
        public long WinStreak { get; set; }

        /// <summary>
        /// Gets or sets Wins
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty wins</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("wins")]
        public long Wins { get; set; }

        /// <summary>
        /// Gets or sets XP
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty xp</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("xp")]
        public long XP { get; set; }

        /// <summary>
        /// GetWins
        /// </summary>
        /// <remarks>
        /// <para>Gets Wins</para>
        /// </remarks>
        /// <returns>Player Wins</returns>
        public long GetWins() => Wins;

        /// <summary>
        /// GetWinsStreak
        /// </summary>
        /// <remarks>
        /// <para>Gets Wins Streak</para>
        /// </remarks>
        /// <returns>Player Wins Streak</returns>
        public long GetWinsStreak() => WinStreak;

        /// <summary>
        /// GetLossStreak
        /// </summary>
        /// <remarks>
        /// <para>Gets Loss Streak</para>
        /// </remarks>
        /// <returns>Player Loss Streak</returns>
        public long GetLossStreak() => LossStreak;
        
        /// <summary>
        /// GetXP
        /// </summary>
        /// <remarks>
        /// <para>Gets XP</para>
        /// </remarks>
        /// <returns>Player XP</returns>
        public long GetXP() => XP;

        /// <summary>
        /// GetLevel
        /// </summary>
        /// <remarks>
        /// <para>Gets Level</para>
        /// </remarks>
        /// <returns>Player Level</returns>
        public long GetLevel() => Level;
    }
}