using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Vainglory_CSharp.Model.Player;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The IncludedStats class
    /// Contains the Objects for the Included stats Node when getting match, included from url.
    /// </summary>
    public class IncludedStats
    {
        /// <summary>
        /// Gets or sets AcesEarned
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty acesEarned</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("acesEarned", NullValueHandling = NullValueHandling.Ignore)]
        public long? AcesEarned { get; set; }

        /// <summary>
        /// Gets or sets Gold
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty gold</para>
        /// </remarks>
        /// See <see cref="double"/>
        [JsonProperty("gold", NullValueHandling = NullValueHandling.Ignore)]
        public double? Gold { get; set; }

        /// <summary>
        /// Gets or sets HeroKills
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty heroKills</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("heroKills", NullValueHandling = NullValueHandling.Ignore)]
        public long? HeroKills { get; set; }

        /// <summary>
        /// Gets or sets KrakenCaptures
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty krakenCaptures</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("krakenCaptures", NullValueHandling = NullValueHandling.Ignore)]
        public long? KrakenCaptures { get; set; }

        /// <summary>
        /// Gets or sets Side
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty side</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// Gets or sets TurretKills
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty turretKills</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("turretKills", NullValueHandling = NullValueHandling.Ignore)]
        public long? TurretKills { get; set; }

        /// <summary>
        /// Gets or sets TurretsRemaining
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty turretsRemaining</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("turretsRemaining", NullValueHandling = NullValueHandling.Ignore)]
        public long? TurretsRemaining { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason4
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_4</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("elo_earned_season_4", NullValueHandling = NullValueHandling.Ignore)]
        public long? EloEarnedSeason4 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason5
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_5</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("elo_earned_season_5", NullValueHandling = NullValueHandling.Ignore)]
        public long? EloEarnedSeason5 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason6
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_6</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("elo_earned_season_6", NullValueHandling = NullValueHandling.Ignore)]
        public long? EloEarnedSeason6 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason7
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_7</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("elo_earned_season_7", NullValueHandling = NullValueHandling.Ignore)]
        public long? EloEarnedSeason7 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason8
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_8</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("elo_earned_season_8", NullValueHandling = NullValueHandling.Ignore)]
        public long? EloEarnedSeason8 { get; set; }

        /// <summary>
        /// Gets or sets EloEarnedSeason9
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty elo_earned_season_9</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("elo_earned_season_9", NullValueHandling = NullValueHandling.Ignore)]
        public long? EloEarnedSeason9 { get; set; }

        /// <summary>
        /// Gets or sets GamesPlayed
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty gamesPlayed</para>
        /// </remarks>
        /// See <see cref="GamesPlayed"/>
        [JsonProperty("gamesPlayed", NullValueHandling = NullValueHandling.Ignore)]
        public GamesPlayed GamesPlayed { get; set; }

        /// <summary>
        /// Gets or sets GuildTag
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty guildTag</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("guildTag", NullValueHandling = NullValueHandling.Ignore)]
        public string GuildTag { get; set; }

        /// <summary>
        /// Gets or sets KarmaLevel
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty karmaLevel</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("karmaLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? KarmaLevel { get; set; }

        /// <summary>
        /// Gets or sets Level
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty level</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public long? Level { get; set; }

        /// <summary>
        /// Gets or sets LifetimeGold
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty lifetimeGold</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("lifetimeGold", NullValueHandling = NullValueHandling.Ignore)]
        public long? LifetimeGold { get; set; }

        /// <summary>
        /// Gets or sets LossStreak
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty lossStreak</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("lossStreak", NullValueHandling = NullValueHandling.Ignore)]
        public long? LossStreak { get; set; }

        /// <summary>
        /// Gets or sets Played
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("played", NullValueHandling = NullValueHandling.Ignore)]
        public long? Played { get; set; }

        /// <summary>
        /// Gets or sets PlayedAral
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played_aral</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("played_aral", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayedAral { get; set; }

        /// <summary>
        /// Gets or sets PlayedBlitz
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played_blitz</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("played_blitz", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayedBlitz { get; set; }

        /// <summary>
        /// Gets or sets PlayedCasual
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played_casual</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("played_casual", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayedCasual { get; set; }

        /// <summary>
        /// Gets or sets PlayedRanked
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty played_ranked</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("played_ranked", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayedRanked { get; set; }

        /// <summary>
        /// Gets or sets RankPoints
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty rankPoints</para>
        /// </remarks>
        /// See <see cref="RankPoints"/>
        [JsonProperty("rankPoints", NullValueHandling = NullValueHandling.Ignore)]
        public RankPoints RankPoints { get; set; }

        /// <summary>
        /// Gets or sets SkillTier
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty skillTier</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("skillTier", NullValueHandling = NullValueHandling.Ignore)]
        public long? SkillTier { get; set; }

        /// <summary>
        /// Gets or sets WinStreak
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty winStreak</para>
        /// </remarks>
        /// See <see cref="long"/>
        [Obsolete("Deprecated as of V1.2.0")]
        [JsonProperty("winStreak", NullValueHandling = NullValueHandling.Ignore)]
        public long? WinStreak { get; set; }

        /// <summary>
        /// Gets or sets Wins
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty wins</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("wins", NullValueHandling = NullValueHandling.Ignore)]
        public long? Wins { get; set; }

        /// <summary>
        /// Gets or sets Xp
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty xp</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("xp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Xp { get; set; }

        /// <summary>
        /// Gets or sets Assists
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty assists</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("assists", NullValueHandling = NullValueHandling.Ignore)]
        public long? Assists { get; set; }

        /// <summary>
        /// Gets or sets CrystalMineCaptures
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty crystalMineCaptures</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("crystalMineCaptures", NullValueHandling = NullValueHandling.Ignore)]
        public long? CrystalMineCaptures { get; set; }

        /// <summary>
        /// Gets or sets Deaths
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty deaths</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("deaths", NullValueHandling = NullValueHandling.Ignore)]
        public long? Deaths { get; set; }

        /// <summary>
        /// Gets or sets Farm
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty farm</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("farm", NullValueHandling = NullValueHandling.Ignore)]
        public long? Farm { get; set; }

        /// <summary>
        /// Gets or sets FirstAfkTime
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty firstAfkTime</para>
        /// </remarks>
        /// See <see cref="double"/>
        [JsonProperty("firstAfkTime", NullValueHandling = NullValueHandling.Ignore)]
        public double? FirstAfkTime { get; set; }

        /// <summary>
        /// Gets or sets GoldMineCaptures
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty goldMineCaptures</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("goldMineCaptures", NullValueHandling = NullValueHandling.Ignore)]
        public long? GoldMineCaptures { get; set; }

        /// <summary>
        /// Gets or sets ItemGrants
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty itemGrants</para>
        /// </remarks>
        /// See <see cref="Dictionary{String, long}"/>
        [JsonProperty("itemGrants", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> ItemGrants { get; set; }

        /// <summary>
        /// Gets or sets ItemSells
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty itemSells</para>
        /// </remarks>
        /// See <see cref="Dictionary{String, long}"/>
        [JsonProperty("itemSells", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> ItemSells { get; set; }

        /// <summary>
        /// Gets or sets ItemUses
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty itemUses</para>
        /// </remarks>
        /// See <see cref="Dictionary{String, long}"/>
        [JsonProperty("itemUses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> ItemUses { get; set; }

        /// <summary>
        /// Gets or sets Items
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty items</para>
        /// </remarks>
        /// See <see cref="string[]"/>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Items { get; set; }

        /// <summary>
        /// Gets or sets JungleKills
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty jungleKills</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("jungleKills", NullValueHandling = NullValueHandling.Ignore)]
        public long? JungleKills { get; set; }

        /// <summary>
        /// Gets or sets Kills
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty kills</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("kills", NullValueHandling = NullValueHandling.Ignore)]
        public long? Kills { get; set; }

        /// <summary>
        /// Gets or sets MinionKills
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty minionKills</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("minionKills", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinionKills { get; set; }

        /// <summary>
        /// Gets or sets NonJungleMinionKills
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty nonJungleMinionKills</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("nonJungleMinionKills", NullValueHandling = NullValueHandling.Ignore)]
        public long? NonJungleMinionKills { get; set; }

        /// <summary>
        /// Gets or sets SkinKey
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty skinKey</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("skinKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SkinKey { get; set; }

        /// <summary>
        /// Gets or sets TurretCaptures
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty turretCaptures</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("turretCaptures", NullValueHandling = NullValueHandling.Ignore)]
        public long? TurretCaptures { get; set; }

        /// <summary>
        /// Gets or sets WentAfk
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty wentAfk</para>
        /// </remarks>
        /// See <see cref="bool"/>
        [JsonProperty("wentAfk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WentAfk { get; set; }

        /// <summary>
        /// Gets or sets Winner
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty winner</para>
        /// </remarks>
        /// See <see cref="bool"/>
        [JsonProperty("winner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Winner { get; set; }
    }
}