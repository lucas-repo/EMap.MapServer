namespace EMap.MapServer.OpenLayers.source
{
    public class Source:BaseObject
    {
        /// <summary>
        /// Attributions
        /// </summary>
        public string attributions { get; set; }
        /// <summary>
        /// Attributions are collapsible.
        /// </summary>
        public bool attributionsCollapsible { get; set; } = true;
        /// <summary>
        /// Projection. Default is the view projection.
        /// </summary>
        public string projection { get; set; }
        /// <summary>
        /// Source state.
        /// </summary>
        public State state { get; set; }
        /// <summary>
        /// Whether to wrap the world horizontally.
        /// </summary>
        public bool wrapX { get; set; }
        public Source() : base("ol.source.Source")
        { }
        public Source(string javaScriptName) : base(javaScriptName)
        { }
    }
}