﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMD.Appointments.Repository.PatientService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/CMD.Patients.Service")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BloodGroupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
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
        public string BloodGroup {
            get {
                return this.BloodGroupField;
            }
            set {
                if ((object.ReferenceEquals(this.BloodGroupField, value) != true)) {
                    this.BloodGroupField = value;
                    this.RaisePropertyChanged("BloodGroup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailId {
            get {
                return this.EmailIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIdField, value) != true)) {
                    this.EmailIdField = value;
                    this.RaisePropertyChanged("EmailId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PatientService.IPatientService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IPatientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/AddPatient", ReplyAction="http://tempuri.org/IPatientService/AddPatientResponse")]
        bool AddPatient(CMD.Appointments.Repository.PatientService.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/AddPatient", ReplyAction="http://tempuri.org/IPatientService/AddPatientResponse")]
        System.Threading.Tasks.Task<bool> AddPatientAsync(CMD.Appointments.Repository.PatientService.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetAllPatients", ReplyAction="http://tempuri.org/IPatientService/GetAllPatientsResponse")]
        CMD.Appointments.Repository.PatientService.Patient[] GetAllPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetAllPatients", ReplyAction="http://tempuri.org/IPatientService/GetAllPatientsResponse")]
        System.Threading.Tasks.Task<CMD.Appointments.Repository.PatientService.Patient[]> GetAllPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatientById", ReplyAction="http://tempuri.org/IPatientService/GetPatientByIdResponse")]
        CMD.Appointments.Repository.PatientService.Patient GetPatientById(string emailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatientById", ReplyAction="http://tempuri.org/IPatientService/GetPatientByIdResponse")]
        System.Threading.Tasks.Task<CMD.Appointments.Repository.PatientService.Patient> GetPatientByIdAsync(string emailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/UpdatePatient", ReplyAction="http://tempuri.org/IPatientService/UpdatePatientResponse")]
        bool UpdatePatient(CMD.Appointments.Repository.PatientService.Patient patient, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/UpdatePatient", ReplyAction="http://tempuri.org/IPatientService/UpdatePatientResponse")]
        System.Threading.Tasks.Task<bool> UpdatePatientAsync(CMD.Appointments.Repository.PatientService.Patient patient, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/RemovePatient", ReplyAction="http://tempuri.org/IPatientService/RemovePatientResponse")]
        bool RemovePatient(string emailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/RemovePatient", ReplyAction="http://tempuri.org/IPatientService/RemovePatientResponse")]
        System.Threading.Tasks.Task<bool> RemovePatientAsync(string emailId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/ValidatePatient", ReplyAction="http://tempuri.org/IPatientService/ValidatePatientResponse")]
        bool ValidatePatient(string emailId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/ValidatePatient", ReplyAction="http://tempuri.org/IPatientService/ValidatePatientResponse")]
        System.Threading.Tasks.Task<bool> ValidatePatientAsync(string emailId, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPatientServiceChannel : CMD.Appointments.Repository.PatientService.IPatientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PatientServiceClient : System.ServiceModel.ClientBase<CMD.Appointments.Repository.PatientService.IPatientService>, CMD.Appointments.Repository.PatientService.IPatientService {
        
        public PatientServiceClient() {
        }
        
        public PatientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PatientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PatientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PatientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddPatient(CMD.Appointments.Repository.PatientService.Patient patient) {
            return base.Channel.AddPatient(patient);
        }
        
        public System.Threading.Tasks.Task<bool> AddPatientAsync(CMD.Appointments.Repository.PatientService.Patient patient) {
            return base.Channel.AddPatientAsync(patient);
        }
        
        public CMD.Appointments.Repository.PatientService.Patient[] GetAllPatients() {
            return base.Channel.GetAllPatients();
        }
        
        public System.Threading.Tasks.Task<CMD.Appointments.Repository.PatientService.Patient[]> GetAllPatientsAsync() {
            return base.Channel.GetAllPatientsAsync();
        }
        
        public CMD.Appointments.Repository.PatientService.Patient GetPatientById(string emailId) {
            return base.Channel.GetPatientById(emailId);
        }
        
        public System.Threading.Tasks.Task<CMD.Appointments.Repository.PatientService.Patient> GetPatientByIdAsync(string emailId) {
            return base.Channel.GetPatientByIdAsync(emailId);
        }
        
        public bool UpdatePatient(CMD.Appointments.Repository.PatientService.Patient patient, string id) {
            return base.Channel.UpdatePatient(patient, id);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePatientAsync(CMD.Appointments.Repository.PatientService.Patient patient, string id) {
            return base.Channel.UpdatePatientAsync(patient, id);
        }
        
        public bool RemovePatient(string emailId) {
            return base.Channel.RemovePatient(emailId);
        }
        
        public System.Threading.Tasks.Task<bool> RemovePatientAsync(string emailId) {
            return base.Channel.RemovePatientAsync(emailId);
        }
        
        public bool ValidatePatient(string emailId, string password) {
            return base.Channel.ValidatePatient(emailId, password);
        }
        
        public System.Threading.Tasks.Task<bool> ValidatePatientAsync(string emailId, string password) {
            return base.Channel.ValidatePatientAsync(emailId, password);
        }
    }
}