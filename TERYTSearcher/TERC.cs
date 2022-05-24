
namespace TERYTSearcher
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class teryt
    {

        private terytCatalog catalogField;

        /// <remarks/>
        public terytCatalog catalog
        {
            get
            {
                return this.catalogField;
            }
            set
            {
                this.catalogField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class terytCatalog
    {

        private terytCatalogRow[] rowField;

        private string nameField;

        private string typeField;

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("row")]
        public terytCatalogRow[] row
        {
            get
            {
                return this.rowField;
            }
            set
            {
                this.rowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class terytCatalogRow
    {

        private byte wOJField;

        private string pOWField;

        private string gMIField;

        private string rODZField;

        private string nAZWAField;

        private string nAZWA_DODField;

        private System.DateTime sTAN_NAField;

        /// <remarks/>
        public byte WOJ
        {
            get
            {
                return this.wOJField;
            }
            set
            {
                this.wOJField = value;
            }
        }

        /// <remarks/>
        public string POW
        {
            get
            {
                return this.pOWField;
            }
            set
            {
                this.pOWField = value;
            }
        }

        /// <remarks/>
        public string GMI
        {
            get
            {
                return this.gMIField;
            }
            set
            {
                this.gMIField = value;
            }
        }

        /// <remarks/>
        public string RODZ
        {
            get
            {
                return this.rODZField;
            }
            set
            {
                this.rODZField = value;
            }
        }

        /// <remarks/>
        public string NAZWA
        {
            get
            {
                return this.nAZWAField;
            }
            set
            {
                this.nAZWAField = value;
            }
        }

        /// <remarks/>
        public string NAZWA_DOD
        {
            get
            {
                return this.nAZWA_DODField;
            }
            set
            {
                this.nAZWA_DODField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime STAN_NA
        {
            get
            {
                return this.sTAN_NAField;
            }
            set
            {
                this.sTAN_NAField = value;
            }
        }
    }



}
