namespace EMap.MapServer.OpenLayers.source
{
    public class UrlTile: TileSource
    {
        
        ///// <summary>
        ///// Optional function to load a tile given a URL. The default is ```js function(imageTile, src) { imageTile.getImage().src = src; }; ```
        ///// </summary>
        //public LoadFunction tileLoadFunction { get; set; }//todo 加载瓦片的委托

        ///// <summary>
        ///// Optional function to get tile URL given a tile coordinate and the projection.
        ///// </summary>
        //public UrlFunction tileUrlFunction { get; set; }//todo 委托

        /// <summary>
        /// A URL for the service. For the RESTful request encoding, this is a URL template.For KVP encoding, it is normal URL.A `{?-?}` template pattern, for example `subdomain{a-f}.domain.com`, may be used instead of defining each one separately in the `urls` option.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// An array of URLs. Requests will be distributed among the URLs in this array.
        /// </summary>
        public string[] urls { get; set; }
        public UrlTile() : base("ol.source.UrlTile ")
        { }
        public UrlTile(string javaScriptName) : base(javaScriptName)
        { }
    }
}