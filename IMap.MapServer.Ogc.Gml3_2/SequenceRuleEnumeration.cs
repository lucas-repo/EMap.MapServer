namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public enum SequenceRuleEnumeration {
        
        
        Linear,
        
        
        Boustrophedonic,
        
        
        [System.Xml.Serialization.XmlEnumAttribute("Cantor-diagonal")]
        Cantordiagonal,
        
        
        Spiral,
        
        
        Morton,
        
        
        Hilbert,
    }
}
