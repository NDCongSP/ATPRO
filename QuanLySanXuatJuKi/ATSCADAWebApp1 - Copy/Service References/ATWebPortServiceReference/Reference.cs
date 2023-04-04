﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATSCADAWebApp.ATWebPortServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WebTag", Namespace="http://schemas.datacontract.org/2004/07/ATSCADA.iWinTools")]
    [System.SerializableAttribute()]
    public partial class WebTag : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValuetoWriteField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeStampField, value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ValuetoWrite {
            get {
                return this.ValuetoWriteField;
            }
            set {
                if ((object.ReferenceEquals(this.ValuetoWriteField, value) != true)) {
                    this.ValuetoWriteField = value;
                    this.RaisePropertyChanged("ValuetoWrite");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ATWebPortServiceReference.InterfaceWebPort")]
    public interface InterfaceWebPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/GetClientCounter", ReplyAction="http://tempuri.org/InterfaceWebPort/GetClientCounterResponse")]
        ulong GetClientCounter();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/GetClientCounter", ReplyAction="http://tempuri.org/InterfaceWebPort/GetClientCounterResponse")]
        System.Threading.Tasks.Task<ulong> GetClientCounterAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/TagListClear", ReplyAction="http://tempuri.org/InterfaceWebPort/TagListClearResponse")]
        void TagListClear();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/TagListClear", ReplyAction="http://tempuri.org/InterfaceWebPort/TagListClearResponse")]
        System.Threading.Tasks.Task TagListClearAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/AddTag", ReplyAction="http://tempuri.org/InterfaceWebPort/AddTagResponse")]
        void AddTag(ATSCADAWebApp.ATWebPortServiceReference.WebTag Tag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/AddTag", ReplyAction="http://tempuri.org/InterfaceWebPort/AddTagResponse")]
        System.Threading.Tasks.Task AddTagAsync(ATSCADAWebApp.ATWebPortServiceReference.WebTag Tag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/GetTag", ReplyAction="http://tempuri.org/InterfaceWebPort/GetTagResponse")]
        ATSCADAWebApp.ATWebPortServiceReference.WebTag GetTag(string Tagname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/GetTag", ReplyAction="http://tempuri.org/InterfaceWebPort/GetTagResponse")]
        System.Threading.Tasks.Task<ATSCADAWebApp.ATWebPortServiceReference.WebTag> GetTagAsync(string Tagname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/UpdateTag", ReplyAction="http://tempuri.org/InterfaceWebPort/UpdateTagResponse")]
        void UpdateTag(string Tagname, string TagValue, string TagStatus, string TagTimeStamp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/UpdateTag", ReplyAction="http://tempuri.org/InterfaceWebPort/UpdateTagResponse")]
        System.Threading.Tasks.Task UpdateTagAsync(string Tagname, string TagValue, string TagStatus, string TagTimeStamp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/WriteTagValue", ReplyAction="http://tempuri.org/InterfaceWebPort/WriteTagValueResponse")]
        void WriteTagValue(string TagName, string ValuetoWrite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceWebPort/WriteTagValue", ReplyAction="http://tempuri.org/InterfaceWebPort/WriteTagValueResponse")]
        System.Threading.Tasks.Task WriteTagValueAsync(string TagName, string ValuetoWrite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InterfaceWebPortChannel : ATSCADAWebApp.ATWebPortServiceReference.InterfaceWebPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InterfaceWebPortClient : System.ServiceModel.ClientBase<ATSCADAWebApp.ATWebPortServiceReference.InterfaceWebPort>, ATSCADAWebApp.ATWebPortServiceReference.InterfaceWebPort {
        
        public InterfaceWebPortClient() {
        }
        
        public InterfaceWebPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InterfaceWebPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InterfaceWebPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InterfaceWebPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ulong GetClientCounter() {
            return base.Channel.GetClientCounter();
        }
        
        public System.Threading.Tasks.Task<ulong> GetClientCounterAsync() {
            return base.Channel.GetClientCounterAsync();
        }
        
        public void TagListClear() {
            base.Channel.TagListClear();
        }
        
        public System.Threading.Tasks.Task TagListClearAsync() {
            return base.Channel.TagListClearAsync();
        }
        
        public void AddTag(ATSCADAWebApp.ATWebPortServiceReference.WebTag Tag) {
            base.Channel.AddTag(Tag);
        }
        
        public System.Threading.Tasks.Task AddTagAsync(ATSCADAWebApp.ATWebPortServiceReference.WebTag Tag) {
            return base.Channel.AddTagAsync(Tag);
        }
        
        public ATSCADAWebApp.ATWebPortServiceReference.WebTag GetTag(string Tagname) {
            return base.Channel.GetTag(Tagname);
        }
        
        public System.Threading.Tasks.Task<ATSCADAWebApp.ATWebPortServiceReference.WebTag> GetTagAsync(string Tagname) {
            return base.Channel.GetTagAsync(Tagname);
        }
        
        public void UpdateTag(string Tagname, string TagValue, string TagStatus, string TagTimeStamp) {
            base.Channel.UpdateTag(Tagname, TagValue, TagStatus, TagTimeStamp);
        }
        
        public System.Threading.Tasks.Task UpdateTagAsync(string Tagname, string TagValue, string TagStatus, string TagTimeStamp) {
            return base.Channel.UpdateTagAsync(Tagname, TagValue, TagStatus, TagTimeStamp);
        }
        
        public void WriteTagValue(string TagName, string ValuetoWrite) {
            base.Channel.WriteTagValue(TagName, ValuetoWrite);
        }
        
        public System.Threading.Tasks.Task WriteTagValueAsync(string TagName, string ValuetoWrite) {
            return base.Channel.WriteTagValueAsync(TagName, ValuetoWrite);
        }
    }
}
