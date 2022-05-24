
namespace TERYTSearcher
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ULIC
    {

        private ULICCatalog catalogField;

        /// <remarks/>
        public ULICCatalog catalog
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
    public partial class ULICCatalog
    {

        private ULICCatalogRow[] rowField;

        private string nameField;

        private string typeField;

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("row")]
        public ULICCatalogRow[] row
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
    public partial class ULICCatalogRow
    {

        private byte wOJField;

        private byte pOWField;

        private byte gMIField;

        private byte rODZ_GMIField;

        private uint sYMField;

        private ushort sYM_ULField;

        private string cECHAField;

        private string nAZWA_1Field;

        private string nAZWA_2Field;

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
        public ushort SYM_UL
        {
            get
            {
                return this.sYM_ULField;
            }
            set
            {
                this.sYM_ULField = value;
            }
        }

        /// <remarks/>
        public string CECHA
        {
            get
            {
                return this.cECHAField;
            }
            set
            {
                this.cECHAField = value;
            }
        }

        /// <remarks/>
        public string NAZWA_1
        {
            get
            {
                return this.nAZWA_1Field;
            }
            set
            {
                this.nAZWA_1Field = value;
            }
        }

        /// <remarks/>
        public string NAZWA_2
        {
            get
            {
                return this.nAZWA_2Field;
            }
            set
            {
                this.nAZWA_2Field = value;
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
