namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public enum IncrementOrder {
        
        
        [System.Xml.Serialization.XmlEnumAttribute("+x+y")]
        xy,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("+y+x")]
        yx,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("+x-y")]
        xy1,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("-x-y")]
        xy2,
    }
}
