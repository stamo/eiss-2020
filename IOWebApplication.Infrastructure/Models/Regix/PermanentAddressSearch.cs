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
//Класификатор на настоящите и постоянните адреси/Справка за постоянен адрес
namespace IOWebApplication.Infrastructure.Models.Regix.PermanentAddressSearch
{
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://egov.bg/RegiX/GRAO/PNA/PermanentAddressRequest")]
    [System.Xml.Serialization.XmlRootAttribute("PermanentAddressRequest", Namespace="http://egov.bg/RegiX/GRAO/PNA/PermanentAddressRequest", IsNullable=false)]
    public partial class PermanentAddressRequestType {
        
        private string eGNField;
        
        private System.DateTime searchDateField;
        
        /// <remarks/>
        public string EGN {
            get {
                return this.eGNField;
            }
            set {
                this.eGNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime SearchDate {
            get {
                return this.searchDateField;
            }
            set {
                this.searchDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://egov.bg/RegiX/GRAO/PNA/PermanentAddressResponse")]
    [System.Xml.Serialization.XmlRootAttribute("PermanentAddressResponse", Namespace="http://egov.bg/RegiX/GRAO/PNA/PermanentAddressResponse", IsNullable=false)]
    public partial class PermanentAddressResponseType {
        
        private string districtCodeField;
        
        private string districtNameField;
        
        private string municipalityCodeField;
        
        private string municipalityNameField;
        
        private string settlementCodeField;
        
        private string settlementNameField;
        
        private string cityAreaCodeField;
        
        private string cityAreaField;
        
        private string locationCodeField;
        
        private string locationNameField;
        
        private string buildingNumberField;
        
        private string entranceField;
        
        private string floorField;
        
        private string apartmentField;
        
        private System.DateTime fromDateField;
        
        private bool fromDateFieldSpecified;
        
        /// <remarks/>
        public string DistrictCode {
            get {
                return this.districtCodeField;
            }
            set {
                this.districtCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DistrictName {
            get {
                return this.districtNameField;
            }
            set {
                this.districtNameField = value;
            }
        }
        
        /// <remarks/>
        public string MunicipalityCode {
            get {
                return this.municipalityCodeField;
            }
            set {
                this.municipalityCodeField = value;
            }
        }
        
        /// <remarks/>
        public string MunicipalityName {
            get {
                return this.municipalityNameField;
            }
            set {
                this.municipalityNameField = value;
            }
        }
        
        /// <remarks/>
        public string SettlementCode {
            get {
                return this.settlementCodeField;
            }
            set {
                this.settlementCodeField = value;
            }
        }
        
        /// <remarks/>
        public string SettlementName {
            get {
                return this.settlementNameField;
            }
            set {
                this.settlementNameField = value;
            }
        }
        
        /// <remarks/>
        public string CityAreaCode {
            get {
                return this.cityAreaCodeField;
            }
            set {
                this.cityAreaCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CityArea {
            get {
                return this.cityAreaField;
            }
            set {
                this.cityAreaField = value;
            }
        }
        
        /// <remarks/>
        public string LocationCode {
            get {
                return this.locationCodeField;
            }
            set {
                this.locationCodeField = value;
            }
        }
        
        /// <remarks/>
        public string LocationName {
            get {
                return this.locationNameField;
            }
            set {
                this.locationNameField = value;
            }
        }
        
        /// <remarks/>
        public string BuildingNumber {
            get {
                return this.buildingNumberField;
            }
            set {
                this.buildingNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Entrance {
            get {
                return this.entranceField;
            }
            set {
                this.entranceField = value;
            }
        }
        
        /// <remarks/>
        public string Floor {
            get {
                return this.floorField;
            }
            set {
                this.floorField = value;
            }
        }
        
        /// <remarks/>
        public string Apartment {
            get {
                return this.apartmentField;
            }
            set {
                this.apartmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime FromDate {
            get {
                return this.fromDateField;
            }
            set {
                this.fromDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FromDateSpecified {
            get {
                return this.fromDateFieldSpecified;
            }
            set {
                this.fromDateFieldSpecified = value;
            }
        }
    }
}