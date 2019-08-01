using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.OpenLayers.proj
{
    public class Projection:JavaScriptConverter
    {
        /// <summary>
        /// The SRS identifier code, e.g. `EPSG:4326`.
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// Units. Required unless a proj4 projection is defined for `code`.
        /// </summary>
        public Units units { get; set; }
        /// <summary>
        /// The validity extent for the SRS.
        /// </summary>
        public double[] extent { get; set; }
        /// <summary>
        /// The axis orientation as specified in Proj4.
        /// </summary>
        public string axisOrientation { get; set; } = "enu";
        /// <summary>
        ///  Whether the projection is valid for the whole globe.
        /// </summary>
        public bool global { get; set; }
        /// <summary>
        /// The meters per unit for the SRS. If not provided, the `units` are used to get the meters per unit from the { @link module:ol/proj/Units~METERS_PER_UNIT} lookup table.
        /// </summary>
        public double metersPerUnit { get; set; }
        /// <summary>
        /// The world extent for the SRS.
        /// </summary>
        public double[] worldExtent { get; set; }
        /// <summary>
        /// * Function to determine resolution at a point. The function is called with a `{number}` view resolution and an `{import("../coordinate.js").Coordinate }` as arguments, and returns the `{number}` resolution in projection units at the passed coordinate.If this is `undefined`, the default {@link module:ol / proj#getPointResolution} function will be used.
        /// </summary>
        /// <returns></returns>
        //public delegate getPointResolution { get; set; }

        public Projection() : base("ol.proj.Projection")
        { }
    }
}
