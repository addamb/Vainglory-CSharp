using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The Match class
    /// Contains the Objects for the data under the data node of type match when getting players from url.
    /// </summary>
    public class Match
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

        /// <summary>
        /// Gets or sets Attributes
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty attributes</para>
        /// </remarks>
        /// See <see cref="MatchAttributes"/>
        [JsonProperty("attributes")]
        public MatchAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets Relationships
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty relationships</para>
        /// </remarks>
        /// See <see cref="MatchRelationships"/>
        [JsonProperty("relationships")]
        public MatchRelationships Relationships { get; set; }

        /// <summary>
        /// Gets or sets Links
        /// </summary>
        /// <remarks>
        /// <para>Set from JsonProperty links</para>
        /// </remarks>
        /// See <see cref="MatchLinks"/>
        [JsonProperty("links")]
        public MatchLinks Links { get; set; }

        /// <summary>
        /// GetId
        /// </summary>
        /// <remarks>
        /// <para>Gets Match Id</para>
        /// </remarks>
        /// <returns>Match Id</returns>
        public string GetId() => Id.ToString();

        //public String GetTitleId() => TitleId;

        //public DateTime GetCreatedAt() => CreatedAt;

        //public long GetDuration() => Duration;

        //public string ShardId() => SharedId;

        //public string GetGameMode() => GameMode;

        //public string GetPatchVersion() => PatchVersion;

        //public List<Roster> GetRoster() => Roster;

        //public List<Assets> GetAssets() => Assets;

        //public MatchStats GetMatchStats() => MatchStats;

        //public Telemetry GetTelemetry()
        //{
        //    if (Telemetry == null)
        //    {
        //        Assets telemetryAsset = GetTelemetryAsset();
        //        if (telemetryAsset == null)
        //        {
        //            throw new Exception("No telemetry asset available.");
        //        }
        //        //Telemetry = S3WebClient.getTelemetry(telemetryAsset.getUrl()).join();
        //    }
        //    return Telemetry;
        //}

        //private Assets GetTelemetryAsset()
        //{
        //    String TELEMETRY_ASSET = "telemetry";

        //    foreach (Assets asset in Assets)
        //    {
        //        if (TELEMETRY_ASSET.Equals(asset.getName()))
        //        {
        //            return asset;
        //        }
        //    }
        //    return null;
        //}

    }
}
