﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockInformationModel", Namespace="http://schemas.datacontract.org/2004/07/Nop.Plugin.Sitecore.Commerce.Inventory.Mo" +
        "dels")]
    [System.SerializableAttribute()]
    public partial class StockInformationModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> AvailabilityDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockStatus StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> AvailabilityDate {
            get {
                return this.AvailabilityDateField;
            }
            set {
                if ((this.AvailabilityDateField.Equals(value) != true)) {
                    this.AvailabilityDateField = value;
                    this.RaisePropertyChanged("AvailabilityDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockStatus", Namespace="http://schemas.datacontract.org/2004/07/Nop.Plugin.Sitecore.Commerce.Inventory.Mo" +
        "dels")]
    public enum StockStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InStock = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OutOfStock = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PreOrderable = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BackOrderable = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderableInformationModel", Namespace="http://schemas.datacontract.org/2004/07/Nop.Plugin.Sitecore.Commerce.Inventory.Mo" +
        "dels")]
    [System.SerializableAttribute()]
    public partial class OrderableInformationModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CartQuantityLimitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> InStockDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> OrderableEndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> OrderableStartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RemainingQuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ShippingDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockStatus StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CartQuantityLimit {
            get {
                return this.CartQuantityLimitField;
            }
            set {
                if ((this.CartQuantityLimitField.Equals(value) != true)) {
                    this.CartQuantityLimitField = value;
                    this.RaisePropertyChanged("CartQuantityLimit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> InStockDate {
            get {
                return this.InStockDateField;
            }
            set {
                if ((this.InStockDateField.Equals(value) != true)) {
                    this.InStockDateField = value;
                    this.RaisePropertyChanged("InStockDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> OrderableEndDate {
            get {
                return this.OrderableEndDateField;
            }
            set {
                if ((this.OrderableEndDateField.Equals(value) != true)) {
                    this.OrderableEndDateField = value;
                    this.RaisePropertyChanged("OrderableEndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> OrderableStartDate {
            get {
                return this.OrderableStartDateField;
            }
            set {
                if ((this.OrderableStartDateField.Equals(value) != true)) {
                    this.OrderableStartDateField = value;
                    this.RaisePropertyChanged("OrderableStartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RemainingQuantity {
            get {
                return this.RemainingQuantityField;
            }
            set {
                if ((this.RemainingQuantityField.Equals(value) != true)) {
                    this.RemainingQuantityField = value;
                    this.RaisePropertyChanged("RemainingQuantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ShippingDate {
            get {
                return this.ShippingDateField;
            }
            set {
                if ((this.ShippingDateField.Equals(value) != true)) {
                    this.ShippingDateField = value;
                    this.RaisePropertyChanged("ShippingDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockInformationUpdateModel", Namespace="http://schemas.datacontract.org/2004/07/Nop.Plugin.Sitecore.Commerce.Inventory.Mo" +
        "dels")]
    [System.SerializableAttribute()]
    public partial class StockInformationUpdateModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateLocationModel[] StockInformationUpdateLocationField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateLocationModel[] StockInformationUpdateLocation {
            get {
                return this.StockInformationUpdateLocationField;
            }
            set {
                if ((object.ReferenceEquals(this.StockInformationUpdateLocationField, value) != true)) {
                    this.StockInformationUpdateLocationField = value;
                    this.RaisePropertyChanged("StockInformationUpdateLocation");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockInformationUpdateLocationModel", Namespace="http://schemas.datacontract.org/2004/07/Nop.Plugin.Sitecore.Commerce.Inventory.Mo" +
        "dels")]
    [System.SerializableAttribute()]
    public partial class StockInformationUpdateLocationModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> AvailabilityDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> AvailabilityDate {
            get {
                return this.AvailabilityDateField;
            }
            set {
                if ((this.AvailabilityDateField.Equals(value) != true)) {
                    this.AvailabilityDateField = value;
                    this.RaisePropertyChanged("AvailabilityDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IndexStockInformationModel", Namespace="http://schemas.datacontract.org/2004/07/Nop.Plugin.Sitecore.Commerce.Inventory.Mo" +
        "dels")]
    [System.SerializableAttribute()]
    public partial class IndexStockInformationModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] InStockLocationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] OrderableLocationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] OutOfStockLocationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PreOrderableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] InStockLocations {
            get {
                return this.InStockLocationsField;
            }
            set {
                if ((object.ReferenceEquals(this.InStockLocationsField, value) != true)) {
                    this.InStockLocationsField = value;
                    this.RaisePropertyChanged("InStockLocations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] OrderableLocations {
            get {
                return this.OrderableLocationsField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderableLocationsField, value) != true)) {
                    this.OrderableLocationsField = value;
                    this.RaisePropertyChanged("OrderableLocations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] OutOfStockLocations {
            get {
                return this.OutOfStockLocationsField;
            }
            set {
                if ((object.ReferenceEquals(this.OutOfStockLocationsField, value) != true)) {
                    this.OutOfStockLocationsField = value;
                    this.RaisePropertyChanged("OutOfStockLocations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PreOrderable {
            get {
                return this.PreOrderableField;
            }
            set {
                if ((this.PreOrderableField.Equals(value) != true)) {
                    this.PreOrderableField = value;
                    this.RaisePropertyChanged("PreOrderable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NopInventoryService.IInventoryService")]
    public interface IInventoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetStocksInformation", ReplyAction="http://tempuri.org/IInventoryService/GetStocksInformationResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationModel[] GetStocksInformation(string shopName, string[] externalproductIds, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetStocksInformation", ReplyAction="http://tempuri.org/IInventoryService/GetStocksInformationResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationModel[]> GetStocksInformationAsync(string shopName, string[] externalproductIds, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetStockInformation", ReplyAction="http://tempuri.org/IInventoryService/GetStockInformationResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationModel GetStockInformation(string shopName, string externalProductId, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetStockInformation", ReplyAction="http://tempuri.org/IInventoryService/GetStockInformationResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationModel> GetStockInformationAsync(string shopName, string externalProductId, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetPreOrderableInformationList", ReplyAction="http://tempuri.org/IInventoryService/GetPreOrderableInformationListResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel[] GetPreOrderableInformationList(string shopName, string[] externalproductIds, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetPreOrderableInformationList", ReplyAction="http://tempuri.org/IInventoryService/GetPreOrderableInformationListResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel[]> GetPreOrderableInformationListAsync(string shopName, string[] externalproductIds, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetPreOrderableInformation", ReplyAction="http://tempuri.org/IInventoryService/GetPreOrderableInformationResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel GetPreOrderableInformation(string shopName, string externalProductId, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetPreOrderableInformation", ReplyAction="http://tempuri.org/IInventoryService/GetPreOrderableInformationResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel> GetPreOrderableInformationAsync(string shopName, string externalProductId, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetBackOrderableInformationList", ReplyAction="http://tempuri.org/IInventoryService/GetBackOrderableInformationListResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel[] GetBackOrderableInformationList(string shopName, string[] externalproductIds, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetBackOrderableInformationList", ReplyAction="http://tempuri.org/IInventoryService/GetBackOrderableInformationListResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel[]> GetBackOrderableInformationListAsync(string shopName, string[] externalproductIds, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetBackOrderableInformation", ReplyAction="http://tempuri.org/IInventoryService/GetBackOrderableInformationResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel GetBackOrderableInformation(string shopName, string externalProductId, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetBackOrderableInformation", ReplyAction="http://tempuri.org/IInventoryService/GetBackOrderableInformationResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel> GetBackOrderableInformationAsync(string shopName, string externalProductId, System.Guid customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetBackInStocksInformation", ReplyAction="http://tempuri.org/IInventoryService/GetBackInStocksInformationResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateModel[] GetBackInStocksInformation(string shopName, string[] externalproductIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetBackInStocksInformation", ReplyAction="http://tempuri.org/IInventoryService/GetBackInStocksInformationResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateModel[]> GetBackInStocksInformationAsync(string shopName, string[] externalproductIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetBackInStockInformation", ReplyAction="http://tempuri.org/IInventoryService/GetBackInStockInformationResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateModel GetBackInStockInformation(string shopName, string externalProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/GetBackInStockInformation", ReplyAction="http://tempuri.org/IInventoryService/GetBackInStockInformationResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateModel> GetBackInStockInformationAsync(string shopName, string externalProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/StocksStatusForIndexing", ReplyAction="http://tempuri.org/IInventoryService/StocksStatusForIndexingResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IndexStockInformationModel[] StocksStatusForIndexing(string[] externalproductIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/StocksStatusForIndexing", ReplyAction="http://tempuri.org/IInventoryService/StocksStatusForIndexingResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IndexStockInformationModel[]> StocksStatusForIndexingAsync(string[] externalproductIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/StockStatusForIndexing", ReplyAction="http://tempuri.org/IInventoryService/StockStatusForIndexingResponse")]
        Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IndexStockInformationModel StockStatusForIndexing(string externalProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInventoryService/StockStatusForIndexing", ReplyAction="http://tempuri.org/IInventoryService/StockStatusForIndexingResponse")]
        System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IndexStockInformationModel> StockStatusForIndexingAsync(string externalProductId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInventoryServiceChannel : Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IInventoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryServiceClient : System.ServiceModel.ClientBase<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IInventoryService>, Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IInventoryService {
        
        public InventoryServiceClient() {
        }
        
        public InventoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationModel[] GetStocksInformation(string shopName, string[] externalproductIds, System.Guid customerId) {
            return base.Channel.GetStocksInformation(shopName, externalproductIds, customerId);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationModel[]> GetStocksInformationAsync(string shopName, string[] externalproductIds, System.Guid customerId) {
            return base.Channel.GetStocksInformationAsync(shopName, externalproductIds, customerId);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationModel GetStockInformation(string shopName, string externalProductId, System.Guid customerId) {
            return base.Channel.GetStockInformation(shopName, externalProductId, customerId);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationModel> GetStockInformationAsync(string shopName, string externalProductId, System.Guid customerId) {
            return base.Channel.GetStockInformationAsync(shopName, externalProductId, customerId);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel[] GetPreOrderableInformationList(string shopName, string[] externalproductIds, System.Guid customerId) {
            return base.Channel.GetPreOrderableInformationList(shopName, externalproductIds, customerId);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel[]> GetPreOrderableInformationListAsync(string shopName, string[] externalproductIds, System.Guid customerId) {
            return base.Channel.GetPreOrderableInformationListAsync(shopName, externalproductIds, customerId);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel GetPreOrderableInformation(string shopName, string externalProductId, System.Guid customerId) {
            return base.Channel.GetPreOrderableInformation(shopName, externalProductId, customerId);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel> GetPreOrderableInformationAsync(string shopName, string externalProductId, System.Guid customerId) {
            return base.Channel.GetPreOrderableInformationAsync(shopName, externalProductId, customerId);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel[] GetBackOrderableInformationList(string shopName, string[] externalproductIds, System.Guid customerId) {
            return base.Channel.GetBackOrderableInformationList(shopName, externalproductIds, customerId);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel[]> GetBackOrderableInformationListAsync(string shopName, string[] externalproductIds, System.Guid customerId) {
            return base.Channel.GetBackOrderableInformationListAsync(shopName, externalproductIds, customerId);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel GetBackOrderableInformation(string shopName, string externalProductId, System.Guid customerId) {
            return base.Channel.GetBackOrderableInformation(shopName, externalProductId, customerId);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.OrderableInformationModel> GetBackOrderableInformationAsync(string shopName, string externalProductId, System.Guid customerId) {
            return base.Channel.GetBackOrderableInformationAsync(shopName, externalProductId, customerId);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateModel[] GetBackInStocksInformation(string shopName, string[] externalproductIds) {
            return base.Channel.GetBackInStocksInformation(shopName, externalproductIds);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateModel[]> GetBackInStocksInformationAsync(string shopName, string[] externalproductIds) {
            return base.Channel.GetBackInStocksInformationAsync(shopName, externalproductIds);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateModel GetBackInStockInformation(string shopName, string externalProductId) {
            return base.Channel.GetBackInStockInformation(shopName, externalProductId);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.StockInformationUpdateModel> GetBackInStockInformationAsync(string shopName, string externalProductId) {
            return base.Channel.GetBackInStockInformationAsync(shopName, externalProductId);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IndexStockInformationModel[] StocksStatusForIndexing(string[] externalproductIds) {
            return base.Channel.StocksStatusForIndexing(externalproductIds);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IndexStockInformationModel[]> StocksStatusForIndexingAsync(string[] externalproductIds) {
            return base.Channel.StocksStatusForIndexingAsync(externalproductIds);
        }
        
        public Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IndexStockInformationModel StockStatusForIndexing(string externalProductId) {
            return base.Channel.StockStatusForIndexing(externalProductId);
        }
        
        public System.Threading.Tasks.Task<Sitecore.Commerce.Connectors.NopCommerce.NopInventoryService.IndexStockInformationModel> StockStatusForIndexingAsync(string externalProductId) {
            return base.Channel.StockStatusForIndexingAsync(externalProductId);
        }
    }
}
