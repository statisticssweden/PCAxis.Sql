﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Koden er generert av et verktøy.
//     Kjøretidsversjon:2.0.50727.3634
//
//     Endringer i denne filen kan føre til feil virkemåte, og vil gå tapt hvis
//     koden genereres på nytt.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace GrandMaster {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class GrandMaster {
        
        private GrandMasterCode[] codesField;
        
        private GrandMasterKeyword[] keywordsField;
        
        private GrandMasterTables tablesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Code", IsNullable=false)]
        public GrandMasterCode[] Codes {
            get {
                return this.codesField;
            }
            set {
                this.codesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Keyword", IsNullable=false)]
        public GrandMasterKeyword[] Keywords {
            get {
                return this.keywordsField;
            }
            set {
                this.keywordsField = value;
            }
        }
        
        /// <remarks/>
        public GrandMasterTables Tables {
            get {
                return this.tablesField;
            }
            set {
                this.tablesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class GrandMasterCode {
        
        private string codeNameField;
        
        private string defaultCodeValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeName {
            get {
                return this.codeNameField;
            }
            set {
                this.codeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string defaultCodeValue {
            get {
                return this.defaultCodeValueField;
            }
            set {
                this.defaultCodeValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ColumnType {
        
        private string descriptionField;
        
        private string modelNameField;
        
        private string deviatingDefaultColumnNameField;
        
        private bool hasSLField;
        
        private int pkField;
        
        private bool pkFieldSpecified;
        
        private bool upperField;
        
        private bool upperFieldSpecified;
        
        private bool dateTimeRoundTripField;
        
        private bool dateTimeRoundTripFieldSpecified;
        
        private bool readBySqlDbConfigField;
        
        private string datatypeField;
        
        private string mandatoryField;
        
        private string foreignkeyField;
        
        private string lengthField;
        
        public ColumnType() {
            this.hasSLField = false;
            this.readBySqlDbConfigField = true;
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modelName {
            get {
                return this.modelNameField;
            }
            set {
                this.modelNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deviatingDefaultColumnName {
            get {
                return this.deviatingDefaultColumnNameField;
            }
            set {
                this.deviatingDefaultColumnNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hasSL {
            get {
                return this.hasSLField;
            }
            set {
                this.hasSLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pk {
            get {
                return this.pkField;
            }
            set {
                this.pkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pkSpecified {
            get {
                return this.pkFieldSpecified;
            }
            set {
                this.pkFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool upper {
            get {
                return this.upperField;
            }
            set {
                this.upperField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool upperSpecified {
            get {
                return this.upperFieldSpecified;
            }
            set {
                this.upperFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DateTimeRoundTrip {
            get {
                return this.dateTimeRoundTripField;
            }
            set {
                this.dateTimeRoundTripField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateTimeRoundTripSpecified {
            get {
                return this.dateTimeRoundTripFieldSpecified;
            }
            set {
                this.dateTimeRoundTripFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool readBySqlDbConfig {
            get {
                return this.readBySqlDbConfigField;
            }
            set {
                this.readBySqlDbConfigField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datatype {
            get {
                return this.datatypeField;
            }
            set {
                this.datatypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mandatory {
            get {
                return this.mandatoryField;
            }
            set {
                this.mandatoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foreignkey {
            get {
                return this.foreignkeyField;
            }
            set {
                this.foreignkeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TableType {
        
        private string descriptionField;
        
        private string commentField;
        
        private ColumnType[] columnsField;
        
        private TableTypeGenerate generateField;
        
        private string modelNameField;
        
        private string tableNameField;
        
        private string aliasField;
        
        private bool hasSLField;
        
        private string defaultAlias_lang2Field;
        
        private bool readBySqlDbConfigField;
        
        public TableType() {
            this.hasSLField = false;
            this.readBySqlDbConfigField = true;
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Column", IsNullable=false)]
        public ColumnType[] Columns {
            get {
                return this.columnsField;
            }
            set {
                this.columnsField = value;
            }
        }
        
        /// <remarks/>
        public TableTypeGenerate generate {
            get {
                return this.generateField;
            }
            set {
                this.generateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modelName {
            get {
                return this.modelNameField;
            }
            set {
                this.modelNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tableName {
            get {
                return this.tableNameField;
            }
            set {
                this.tableNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hasSL {
            get {
                return this.hasSLField;
            }
            set {
                this.hasSLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string defaultAlias_lang2 {
            get {
                return this.defaultAlias_lang2Field;
            }
            set {
                this.defaultAlias_lang2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool readBySqlDbConfig {
            get {
                return this.readBySqlDbConfigField;
            }
            set {
                this.readBySqlDbConfigField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TableTypeGenerate {
        
        private object onlyForDbconfigField;
        
        private object dontMakeRowClassesField;
        
        private object getByPkField;
        
        private TableTypeGenerateGetAllRows getAllRowsField;
        
        private TableTypeGenerateDictionary[] dictionaryField;
        
        /// <remarks/>
        public object onlyForDbconfig {
            get {
                return this.onlyForDbconfigField;
            }
            set {
                this.onlyForDbconfigField = value;
            }
        }
        
        /// <remarks/>
        public object dontMakeRowClasses {
            get {
                return this.dontMakeRowClassesField;
            }
            set {
                this.dontMakeRowClassesField = value;
            }
        }
        
        /// <remarks/>
        public object getByPk {
            get {
                return this.getByPkField;
            }
            set {
                this.getByPkField = value;
            }
        }
        
        /// <remarks/>
        public TableTypeGenerateGetAllRows getAllRows {
            get {
                return this.getAllRowsField;
            }
            set {
                this.getAllRowsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dictionary")]
        public TableTypeGenerateDictionary[] Dictionary {
            get {
                return this.dictionaryField;
            }
            set {
                this.dictionaryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TableTypeGenerateGetAllRows {
        
        private string keyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TableTypeGenerateDictionary {
        
        private TableTypeGenerateDictionaryArg[] argField;
        
        private TableTypeGenerateDictionaryIs_not_null is_not_nullField;
        
        private string keyField;
        
        private string suffField;
        
        private bool listField;
        
        public TableTypeGenerateDictionary() {
            this.listField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arg")]
        public TableTypeGenerateDictionaryArg[] arg {
            get {
                return this.argField;
            }
            set {
                this.argField = value;
            }
        }
        
        /// <remarks/>
        public TableTypeGenerateDictionaryIs_not_null is_not_null {
            get {
                return this.is_not_nullField;
            }
            set {
                this.is_not_nullField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string suff {
            get {
                return this.suffField;
            }
            set {
                this.suffField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool List {
            get {
                return this.listField;
            }
            set {
                this.listField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TableTypeGenerateDictionaryArg {
        
        private string idField;
        
        private string argClassField;
        
        public TableTypeGenerateDictionaryArg() {
            this.argClassField = "string";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("string")]
        public string argClass {
            get {
                return this.argClassField;
            }
            set {
                this.argClassField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TableTypeGenerateDictionaryIs_not_null {
        
        private string columnModelNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string columnModelName {
            get {
                return this.columnModelNameField;
            }
            set {
                this.columnModelNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class GrandMasterKeyword {
        
        private string modelNameField;
        
        private bool optionalField;
        
        private bool optionalFieldSpecified;
        
        private string defaultLocalNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modelName {
            get {
                return this.modelNameField;
            }
            set {
                this.modelNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool optional {
            get {
                return this.optionalField;
            }
            set {
                this.optionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool optionalSpecified {
            get {
                return this.optionalFieldSpecified;
            }
            set {
                this.optionalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string defaultLocalName {
            get {
                return this.defaultLocalNameField;
            }
            set {
                this.defaultLocalNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class GrandMasterTables {
        
        private TableType[] tableField;
        
        private string cNMMversionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Table")]
        public TableType[] Table {
            get {
                return this.tableField;
            }
            set {
                this.tableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CNMMversion {
            get {
                return this.cNMMversionField;
            }
            set {
                this.cNMMversionField = value;
            }
        }
    }
}
