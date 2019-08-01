using System;
using System.Collections.Generic;

namespace EMap.MapServer.OpenLayers.proj
{
    public enum Units
    {
        DEGREES,
        FEET,
        METERS,
        PIXELS,
        TILE_PIXELS,
        USFEET
    }
    public static class UnitsHelper
    {
        static Dictionary<Units, string> UnitsDic;
        static Dictionary<Units, double> METERS_PER_UNIT;
        static UnitsHelper()
        {
            if (UnitsDic == null)
            {
                UnitsDic = new Dictionary<Units, string>()
                {
                    { Units.DEGREES,"degrees" },
                    { Units.FEET,"ft" },
                    { Units.METERS,"m" },
                    { Units.PIXELS,"pixels" },
                    { Units.TILE_PIXELS,"tile-pixels" },
                    { Units.USFEET,"us-ft" }
                };
            }
            if (METERS_PER_UNIT == null)
            {
                METERS_PER_UNIT = new Dictionary<Units, double>()
                {
                    { Units.DEGREES,2 * Math.PI * 6370997 / 360 },
                    { Units.FEET,0.3048},
                    { Units.METERS,1 },
                    { Units.USFEET,1200 / 3937 }
                };
            }
        }
        public static string GetUnitsStr(Units units)
        {
            return UnitsDic[units];
        }
        public static double GetMetersPerUnit(Units units)
        {
            return METERS_PER_UNIT[units];
        }
    }
}