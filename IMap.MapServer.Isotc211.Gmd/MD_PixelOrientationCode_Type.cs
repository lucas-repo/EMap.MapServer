namespace IMap.MapServer.Isotc211.Gmd {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute("MD_PixelOrientationCode", Namespace="http://www.isotc211.org/2005/gmd", IsNullable=false)]
    public enum MD_PixelOrientationCode_Type {
        
        
        center,
        
        
        lowerLeft,
        
        
        lowerRight,
        
        
        upperRight,
        
        
        upperLeft,
    }
}
