﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.7.3081.0.
// 
//Търговски регистър/Справка за актуално състояние за всички вписани обстоятелства по раздели(v3)
namespace IOWebApplication.Infrastructure.Models.Regix.PersonDataSearch
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egov.bg/RegiX/GRAO/NBD/PersonDataRequest")]
    [System.Xml.Serialization.XmlRootAttribute("PersonDataRequest", Namespace = "http://egov.bg/RegiX/GRAO/NBD/PersonDataRequest", IsNullable = false)]
    public partial class PersonDataRequestType
    {

        private string eGNField;

        /// <remarks/>
        public string EGN
        {
            get
            {
                return this.eGNField;
            }
            set
            {
                this.eGNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egov.bg/RegiX/GRAO/NBD/PersonDataResponse")]
    [System.Xml.Serialization.XmlRootAttribute("PersonDataResponse", Namespace = "http://egov.bg/RegiX/GRAO/NBD/PersonDataResponse", IsNullable = false)]
    public partial class PersonDataResponseType
    {

        private PersonNames personNamesField;

        private string aliasField;

        private PersonNames latinNamesField;

        private PersonNames foreignNamesField;

        private Gender genderField;

        private string eGNField;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private string placeBirthField;

        private Nationality nationalityField;

        private System.DateTime deathDateField;

        private bool deathDateFieldSpecified;

        /// <remarks/>
        public PersonNames PersonNames
        {
            get
            {
                return this.personNamesField;
            }
            set
            {
                this.personNamesField = value;
            }
        }

        /// <remarks/>
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        public PersonNames LatinNames
        {
            get
            {
                return this.latinNamesField;
            }
            set
            {
                this.latinNamesField = value;
            }
        }

        /// <remarks/>
        public PersonNames ForeignNames
        {
            get
            {
                return this.foreignNamesField;
            }
            set
            {
                this.foreignNamesField = value;
            }
        }

        /// <remarks/>
        public Gender Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public string EGN
        {
            get
            {
                return this.eGNField;
            }
            set
            {
                this.eGNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDateSpecified
        {
            get
            {
                return this.birthDateFieldSpecified;
            }
            set
            {
                this.birthDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string PlaceBirth
        {
            get
            {
                return this.placeBirthField;
            }
            set
            {
                this.placeBirthField = value;
            }
        }

        /// <remarks/>
        public Nationality Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DeathDate
        {
            get
            {
                return this.deathDateField;
            }
            set
            {
                this.deathDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeathDateSpecified
        {
            get
            {
                return this.deathDateFieldSpecified;
            }
            set
            {
                this.deathDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egov.bg/RegiX/GRAO/NBD")]
    public partial class PersonNames
    {

        private object firstNameField;

        private object surNameField;

        private object familyNameField;

        /// <remarks/>
        public object FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public object SurName
        {
            get
            {
                return this.surNameField;
            }
            set
            {
                this.surNameField = value;
            }
        }

        /// <remarks/>
        public object FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egov.bg/RegiX/GRAO/NBD")]
    public partial class PersonRelationType
    {

        private RelationType relationCodeField;

        private bool relationCodeFieldSpecified;

        private string eGNField;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private string firstNameField;

        private string surNameField;

        private string familyNameField;

        private Gender genderField;

        private Nationality nationalityField;

        private System.DateTime deathDateField;

        private bool deathDateFieldSpecified;

        /// <remarks/>
        public RelationType RelationCode
        {
            get
            {
                return this.relationCodeField;
            }
            set
            {
                this.relationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelationCodeSpecified
        {
            get
            {
                return this.relationCodeFieldSpecified;
            }
            set
            {
                this.relationCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string EGN
        {
            get
            {
                return this.eGNField;
            }
            set
            {
                this.eGNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDateSpecified
        {
            get
            {
                return this.birthDateFieldSpecified;
            }
            set
            {
                this.birthDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string SurName
        {
            get
            {
                return this.surNameField;
            }
            set
            {
                this.surNameField = value;
            }
        }

        /// <remarks/>
        public string FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <remarks/>
        public Gender Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public Nationality Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                this.nationalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DeathDate
        {
            get
            {
                return this.deathDateField;
            }
            set
            {
                this.deathDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeathDateSpecified
        {
            get
            {
                return this.deathDateFieldSpecified;
            }
            set
            {
                this.deathDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egov.bg/RegiX/GRAO/NBD")]
    public enum RelationType
    {

        /// <remarks/>
        Баща,

        /// <remarks/>
        Осиновител,

        /// <remarks/>
        Майка,

        /// <remarks/>
        Осиновителка,

        /// <remarks/>
        Син,

        /// <remarks/>
        Дъщеря,

        /// <remarks/>
        Брат,

        /// <remarks/>
        Сестра,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egov.bg/RegiX/GRAO/NBD")]
    public partial class Gender
    {

        private int genderCodeField;

        private bool genderCodeFieldSpecified;

        private GenderNameType genderNameField;

        private bool genderNameFieldSpecified;

        /// <remarks/>
        public int GenderCode
        {
            get
            {
                return this.genderCodeField;
            }
            set
            {
                this.genderCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenderCodeSpecified
        {
            get
            {
                return this.genderCodeFieldSpecified;
            }
            set
            {
                this.genderCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public GenderNameType GenderName
        {
            get
            {
                return this.genderNameField;
            }
            set
            {
                this.genderNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenderNameSpecified
        {
            get
            {
                return this.genderNameFieldSpecified;
            }
            set
            {
                this.genderNameFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egov.bg/RegiX/GRAO/NBD")]
    public enum GenderNameType
    {

        /// <remarks/>
        Мъж,

        /// <remarks/>
        Жена,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://egov.bg/RegiX/GRAO/NBD")]
    public partial class Nationality
    {

        private string nationalityCodeField;

        private string nationalityNameField;

        private string nationalityCode2Field;

        private string nationalityName2Field;

        /// <remarks/>
        public string NationalityCode
        {
            get
            {
                return this.nationalityCodeField;
            }
            set
            {
                this.nationalityCodeField = value;
            }
        }

        /// <remarks/>
        public string NationalityName
        {
            get
            {
                return this.nationalityNameField;
            }
            set
            {
                this.nationalityNameField = value;
            }
        }

        /// <remarks/>
        public string NationalityCode2
        {
            get
            {
                return this.nationalityCode2Field;
            }
            set
            {
                this.nationalityCode2Field = value;
            }
        }

        /// <remarks/>
        public string NationalityName2
        {
            get
            {
                return this.nationalityName2Field;
            }
            set
            {
                this.nationalityName2Field = value;
            }
        }
    }
}