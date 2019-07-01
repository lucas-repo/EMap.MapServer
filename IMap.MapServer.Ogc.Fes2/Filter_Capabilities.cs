using EMap.MapServer.Ogc.Ows1_1;

namespace EMap.MapServer.Ogc.Fes2 {
    
    
    
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/fes/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/fes/2.0", IsNullable=false)]
    public partial class Filter_Capabilities {
        
        private DomainType[] conformanceField;
        
        private ResourceIdentifierType[] id_CapabilitiesField;
        
        private Scalar_CapabilitiesType scalar_CapabilitiesField;
        
        private Spatial_CapabilitiesType spatial_CapabilitiesField;
        
        private Temporal_CapabilitiesType temporal_CapabilitiesField;
        
        private AvailableFunctionType[] functionsField;
        
        private Extended_CapabilitiesType extended_CapabilitiesField;
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Constraint", IsNullable=false)]
        public DomainType[] Conformance {
            get {
                return this.conformanceField;
            }
            set {
                this.conformanceField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ResourceIdentifier", IsNullable=false)]
        public ResourceIdentifierType[] Id_Capabilities {
            get {
                return this.id_CapabilitiesField;
            }
            set {
                this.id_CapabilitiesField = value;
            }
        }
        
        
        public Scalar_CapabilitiesType Scalar_Capabilities {
            get {
                return this.scalar_CapabilitiesField;
            }
            set {
                this.scalar_CapabilitiesField = value;
            }
        }
        
        
        public Spatial_CapabilitiesType Spatial_Capabilities {
            get {
                return this.spatial_CapabilitiesField;
            }
            set {
                this.spatial_CapabilitiesField = value;
            }
        }
        
        
        public Temporal_CapabilitiesType Temporal_Capabilities {
            get {
                return this.temporal_CapabilitiesField;
            }
            set {
                this.temporal_CapabilitiesField = value;
            }
        }
        
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Function", IsNullable=false)]
        public AvailableFunctionType[] Functions {
            get {
                return this.functionsField;
            }
            set {
                this.functionsField = value;
            }
        }
        
        
        public Extended_CapabilitiesType Extended_Capabilities {
            get {
                return this.extended_CapabilitiesField;
            }
            set {
                this.extended_CapabilitiesField = value;
            }
        }
    }
}
