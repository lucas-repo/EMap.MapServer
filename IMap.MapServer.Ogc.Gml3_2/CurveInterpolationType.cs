namespace EMap.MapServer.Ogc.Gml3_2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml/3.2")]
    public enum CurveInterpolationType {
        
        
        linear,
        
        
        geodesic,
        
        
        circularArc3Points,
        
        
        circularArc2PointWithBulge,
        
        
        circularArcCenterPointWithRadius,
        
        
        elliptical,
        
        
        clothoid,
        
        
        conic,
        
        
        polynomialSpline,
        
        
        cubicSpline,
        
        
        rationalSpline,
    }
}
