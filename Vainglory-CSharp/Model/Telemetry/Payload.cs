using Newtonsoft.Json;
using System;

namespace Vainglory_CSharp.Model
{
    /// <summary>
    /// The Payload class
    /// Contains the Objects for the payload Node when getting match from url.
    /// </summary>
    public class Payload
    {
        /// <summary>
        /// Gets or sets Hero
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Hero</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Hero", NullValueHandling = NullValueHandling.Ignore)]
        public string Hero { get; set; }

        /// <summary>
        /// Gets or sets Team
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Team</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Team", NullValueHandling = NullValueHandling.Ignore)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or sets Player
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Player</para>
        /// </remarks>
        /// See <see cref="Guid"/>
        [JsonProperty("Player", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Player { get; set; }

        /// <summary>
        /// Gets or sets Handle
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Handle</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets Skin
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Skin</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Skin", NullValueHandling = NullValueHandling.Ignore)]
        public string Skin { get; set; }

        /// <summary>
        /// Gets or sets Actor
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Actor</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Actor", NullValueHandling = NullValueHandling.Ignore)]
        public string Actor { get; set; }

        /// <summary>
        /// Gets or sets Level
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Level</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("Level", NullValueHandling = NullValueHandling.Ignore)]
        public long? Level { get; set; }

        /// <summary>
        /// Gets or sets LifetimeGold
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty LifetimeGold</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("LifetimeGold", NullValueHandling = NullValueHandling.Ignore)]
        public long? LifetimeGold { get; set; }

        /// <summary>
        /// Gets or sets TargetActor
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty TargetActor</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("TargetActor", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetActor { get; set; }

        /// <summary>
        /// Gets or sets TargetTeam
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty TargetTeam</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("TargetTeam", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetTeam { get; set; }

        /// <summary>
        /// Gets or sets Source
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Source</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets Heal
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Heal</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("Heal", NullValueHandling = NullValueHandling.Ignore)]
        public long? Heal { get; set; }

        /// <summary>
        /// Gets or sets Healed
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Healed</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("Healed", NullValueHandling = NullValueHandling.Ignore)]
        public long? Healed { get; set; }

        /// <summary>
        /// Gets or sets IsHero
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty IsHero</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("IsHero", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsHero { get; set; }

        /// <summary>
        /// Gets or sets TargetIsHero
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty TargetIsHero</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("TargetIsHero", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetIsHero { get; set; }

        /// <summary>
        /// Gets or sets Talent
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Talent</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Talent", NullValueHandling = NullValueHandling.Ignore)]
        public string Talent { get; set; }

        /// <summary>
        /// Gets or sets Item
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Item</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Item", NullValueHandling = NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>
        /// Gets or sets Cost
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Cost</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("Cost", NullValueHandling = NullValueHandling.Ignore)]
        public long? Cost { get; set; }

        /// <summary>
        /// Gets or sets RemainingGold
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty RemainingGold</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("RemainingGold", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemainingGold { get; set; }

        /// <summary>
        /// Gets or sets Position
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Position</para>
        /// </remarks>
        /// See <see cref="double"/>
        [JsonProperty("Position", NullValueHandling = NullValueHandling.Ignore)]
        public double[] Position { get; set; }

        /// <summary>
        /// Gets or sets Ability
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Ability</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Ability", NullValueHandling = NullValueHandling.Ignore)]
        public string Ability { get; set; }

        /// <summary>
        /// Gets or sets TargetPosition
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty TargetPosition</para>
        /// </remarks>
        /// See <see cref="double"/>
        [JsonProperty("TargetPosition", NullValueHandling = NullValueHandling.Ignore)]
        public double[] TargetPosition { get; set; }

        /// <summary>
        /// Gets or sets Vamp
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Vamp</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("Vamp", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Vamp { get; set; }

        /// <summary>
        /// Gets or sets Killed
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Killed</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Killed", NullValueHandling = NullValueHandling.Ignore)]
        public string Killed { get; set; }

        /// <summary>
        /// Gets or sets KilledTeam
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty KilledTeam</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("KilledTeam", NullValueHandling = NullValueHandling.Ignore)]
        public string KilledTeam { get; set; }

        /// <summary>
        /// Gets or sets Gold
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Gold</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("Gold", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Gold { get; set; }

        /// <summary>
        /// Gets or sets Target
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Target</para>
        /// </remarks>
        /// See <see cref="string"/>
        [JsonProperty("Target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets Damage
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Damage</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("Damage", NullValueHandling = NullValueHandling.Ignore)]
        public long? Damage { get; set; }

        /// <summary>
        /// Gets or sets Dealt
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty Dealt</para>
        /// </remarks>
        /// See <see cref="long"/>
        [JsonProperty("Dealt", NullValueHandling = NullValueHandling.Ignore)]
        public long? Dealt { get; set; }
    }
}