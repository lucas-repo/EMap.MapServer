namespace EMap.MapServer.Ogc.Ows2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows/2.0")]
    public enum RangeTypeRangeClosure {
        
        
        closed,
        
        
        open,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("open-closed")]
        openclosed,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("closed-open")]
        closedopen,
    }
}
