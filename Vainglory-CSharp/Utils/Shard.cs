using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Vainglory_CSharp.Utils
{
    public enum Shard
    {
        [Description("cn")]
        China, // cn
        [Description("tournament-cn")]
        ChinaTournament,

        [Description("na")]
        NorthAmerica, // na
        [Description("tournament-na")]
        NorthAmericaTournaments,// tournament-na

        [Description("eu")]
        Europe, // eu
        [Description("tournament-eu")]
        EuropeTournaments, //tournament-eu

        [Description("sa")]
        SouthAmerica,// sa
        [Description("tournament-sa")]
        SouthAmericaTournaments, //tournament-sa

        [Description("ea")]
        EastAsia,// ea
        [Description("tournament-ea")]
        EastAsiaTournaments, //tournament-ea

        [Description("sg")]
        SoutheastAsia,// sg
        [Description("tournament-sg")]
        SoutheastAsiaTournaments //tournament-sg

    }

    public class ShardId
    {
        public string GetDescription(Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
    }
}
