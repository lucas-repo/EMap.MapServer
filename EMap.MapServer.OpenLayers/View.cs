using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.OpenLayers
{
    public class View:JavaScriptConverter
    {
        public double[] center { get; set; }
        /// <summary>
        ///  Enable rotation.If `false`, a rotation constraint that always sets the rotation to zero is used.The `constrainRotation` option has no effect if `enableRotation` is `false`.
        /// </summary>
        public bool enableRotation { get; set; } = true;
        /// <summary>
        /// The extent that constrains the view, in other words, nothing outside of this extent can be visible on the map.
        /// </summary>
        public double[] extent { get; set; }
        /// <summary>
        /// If true, the extent constraint will only apply to the view center and not the whole extent.
        /// </summary>
        public bool? constrainOnlyCenter { get; set; }
        /// <summary>
        /// If true, the extent constraint will be applied smoothly, i.e.allow the view to go slightly outside of the given `extent`.
        /// </summary>
        public bool smoothExtentConstraint { get; set; } = true;
        /// <summary>
        /// The maximum resolution used to determine the resolution constraint.It is used together with `minResolution` (or `maxZoom`) and `zoomFactor`. If unspecified it is calculated in such a way that the projection's validity extent fits in a 256x256 px tile. If the projection is Spherical Mercator(the default) then `maxResolution` defaults to `40075016.68557849 / 256 = 156543.03392804097`.
        /// </summary>
        public double? maxResolution { get; set; }
        /// <summary>
        /// The maximum zoom level used to determine the resolution constraint.It is used together with `minZoom` (or `maxResolution`) and `zoomFactor`.  Note that if `minResolution` is also provided, it is given precedence over `maxZoom`.
        /// </summary>
        public int maxZoom { get; set; } = 28;
        /// <summary>
        /// The minimum zoom level used to determine the resolution constraint.It is used together with `maxZoom` (or `minResolution`) and `zoomFactor`.  Note that if `maxResolution` is also provided, it is given precedence over `minZoom`.
        /// </summary>
        public int minZoom { get; set; }
        /// <summary>
        /// The minimum resolution used to determine the resolution constraint.It is used together with `maxResolution` (or `minZoom`) and `zoomFactor`.  If unspecified it is calculated assuming 29 zoom levels(with a factor of 2). If the projection is Spherical Mercator (the default) then `minResolution` defaults to `40075016.68557849 / 256 / Math.pow(2, 28) = 0.0005831682455839253`.
        /// </summary>
        public double? minResolution { get; set; }
        /// <summary>
        /// No more than one world is visible
        /// </summary>
        public bool? multiWorld { get; set; }
        /// <summary>
        /// If true, the view will always animate to the closest zoom level after an interaction; false means intermediary zoom levels are allowed.
        /// </summary>
        public bool? constrainResolution { get; set; }
        /// <summary>
        /// If true, the resolution min/max values will be applied smoothly, i. e.allow the view to exceed slightly the given resolution or zoom bounds.
        /// </summary>
        public bool smoothResolutionConstraint { get; set; } = true;
        /// <summary>
        /// 投影，默认为Spherical Mercator，值为'EPSG:3857'，OpenLayers只支持4326和3857
        /// </summary>
        public string projection { get; set; } = "EPSG:3857";
        /// <summary>
        /// Resolutions to determine the resolution constraint.If set the `maxResolution`, `minResolution`, `minZoom`, `maxZoom`, and `zoomFactor` options are ignored.
        /// </summary>
        public double[] resolutions { get; set; }
        /// <summary>
        /// The initial resolution for the view. The units are `projection` units per pixel(e.g.meters per pixel). An alternative to setting this is to set `zoom`. Layer sources will not be fetched if neither this nor `zoom` are defined, but they can be set later
        /// </summary>
        public double? resolution { get; set; }
        /// <summary>
        /// The initial rotation for the view in radians (positive rotation clockwise, 0 means North).
        /// </summary>
        public double? rotation { get; set; }
        /// <summary>
        /// Only used if `resolution` is not defined. Zoom level used to calculate the initial resolution for the view.
        /// </summary>
        public int zoom { get; set; }
        /// <summary>
        /// 缩放比例
        /// </summary>
        public double ZoomFactor { get; set; } = 2;
        public View() : base("ol.View")
        { }
    }
}
