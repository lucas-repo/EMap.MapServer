using SharpMapServer.Ogc.Ows1_1;

namespace SharpMapServer.Ogc.Wmts1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/wmts/1.0")]
    public partial class ContentsType : ContentsBaseType {
        
        private TileMatrixSet[] tileMatrixSetField;
        
        
        [System.Xml.Serialization.XmlElementAttribute("TileMatrixSet")]
        public TileMatrixSet[] TileMatrixSet {
            get {
                return this.tileMatrixSetField;
            }
            set {
                this.tileMatrixSetField = value;
            }
        }
        //[System.Xml.Serialization.XmlElementAttribute("DatasetDescriptionSummary", Type = typeof(DatasetDescriptionSummaryBaseType))]
        //[System.Xml.Serialization.XmlElementAttribute("Layer",Type =typeof(LayerType))]
        //public new DatasetDescriptionSummaryBaseType[] DatasetDescriptionSummary
        //{
        //    get
        //    {
        //        return base.DatasetDescriptionSummary; 
        //    }
        //    set
        //    {
        //        base.DatasetDescriptionSummary = value;
        //    }
        //}
    }
}
