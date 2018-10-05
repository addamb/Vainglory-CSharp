using System;
using System.ComponentModel;
using System.Reflection;

namespace Vainglory_CSharp.Model.Match
{
    /// <summary>
    /// The ShardId enum,
    /// Contains the enums of the returned Shard from the match.
    /// </summary>
    public enum ShardId
    {
        [Description("China")]
        CN,
        [Description("North America")]
        NA,
        [Description("Europe")]
        EU,
        [Description("South America")]
        SA,
        [Description("East Asia")]
        EA,
        [Description("Southeast Asia")]
        SG
    }
}