
namespace TERYTSearcher
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SIMC
    {

        private SIMCCatalog catalogField;

        /// <remarks/>
        public SIMCCatalog catalog
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
    public partial class SIMCCatalog
    {

        private SIMCCatalogRow[] rowField;

        private string nameField;

        private string typeField;

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("row")]
        public SIMCCatalogRow[] row
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
    public partial class SIMCCatalogRow
    {

        private byte wOJField;

        private byte pOWField;

        private byte gMIField;

        private byte rODZ_GMIField;

        private byte rmField;

        private byte mzField;

        private string nAZWAField;

        private uint sYMField;

        private uint sYMPODField;

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
        public byte POW
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
        public byte GMI
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
        public byte RODZ_GMI
        {
            get
            {
                return this.rODZ_GMIField;
            }
            set
            {
                this.rODZ_GMIField = value;
            }
        }

        /// <remarks/>
        public byte RM
        {
            get
            {
                return this.rmField;
            }
            set
            {
                this.rmField = value;
            }
        }

        /// <remarks/>
        public byte MZ
        {
            get
            {
                return this.mzField;
            }
            set
            {
                this.mzField = value;
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
        public uint SYM
        {
            get
            {
                return this.sYMField;
            }
            set
            {
                this.sYMField = value;
            }
        }

        /// <remarks/>
        public uint SYMPOD
        {
            get
            {
                return this.sYMPODField;
            }
            set
            {
                this.sYMPODField = value;
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
