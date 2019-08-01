using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.MapServer.OpenLayers.source
{
    public class Wmts : TileImage
    {
        /// <summary>
        /// Request encoding.
        /// </summary>
        public string requestEncoding { get; set; } = "KVP";
        /// <summary>
        /// Layer name as advertised in the WMTS capabilities.
        /// </summary>
        public string layer { get; set; }
        /// <summary>
        /// Style name as advertised in the WMTS capabilities.
        /// </summary>
        public string style { get; set; }
        /// <summary>
        /// Image format. Only used when `requestEncoding` is `'KVP'`.
        /// </summary>
        public string format { get; set; } = "image/jpeg";
        /// <summary>
        /// WMTS version.
        /// </summary>
        public string version { get; set; } = "1.0.0";
        public string matrixSet { get; set; }
        ///// <summary>
        ///// Additional "dimensions" for tile requests. This is an object with properties named like the advertised WMTS dimensions.
        ///// </summary>
        //public object dimensions { get; set; }//todo !Object不知道什么类型
        
        public Wmts() : base("ol.source.WMTS")
        {
            
        }
    }
}
