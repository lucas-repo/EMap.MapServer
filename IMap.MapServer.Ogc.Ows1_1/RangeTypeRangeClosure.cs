namespace IMap.MapServer.Ogc.Ows1_1 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/1.1")]
    public enum RangeTypeRangeClosure {
        
        
        closed,
        
        
        open,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("open-closed")]
        openclosed,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("closed-open")]
        closedopen,
    }
}
