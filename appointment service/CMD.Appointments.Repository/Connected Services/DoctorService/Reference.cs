﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMD.Appointments.Repository.DoctorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor", Namespace="http://schemas.datacontract.org/2004/07/CMD.Doctors.Service")]
    [System.SerializableAttribute()]
    public partial class Doctor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NpiNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PracticeLocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialityField;
        
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
        public string NpiNo {
            get {
                return this.NpiNoField;
            }
            set {
                if ((object.ReferenceEquals(this.NpiNoField, value) != true)) {
                    this.NpiNoField = value;
                    this.RaisePropertyChanged("NpiNo");
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
        public string PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNoField, value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PracticeLocation {
            get {
                return this.PracticeLocationField;
            }
            set {
                if ((object.ReferenceEquals(this.PracticeLocationField, value) != true)) {
                    this.PracticeLocationField = value;
                    this.RaisePropertyChanged("PracticeLocation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Speciality {
            get {
                return this.SpecialityField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialityField, value) != true)) {
                    this.SpecialityField = value;
                    this.RaisePropertyChanged("Speciality");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DoctorService.IDoctorService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IDoctorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/ValidateDoctor", ReplyAction="http://tempuri.org/IDoctorService/ValidateDoctorResponse")]
        bool ValidateDoctor(string emailId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/ValidateDoctor", ReplyAction="http://tempuri.org/IDoctorService/ValidateDoctorResponse")]
        System.Threading.Tasks.Task<bool> ValidateDoctorAsync(string emailId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/AddDoctor", ReplyAction="http://tempuri.org/IDoctorService/AddDoctorResponse")]
        bool AddDoctor(CMD.Appointments.Repository.DoctorService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/AddDoctor", ReplyAction="http://tempuri.org/IDoctorService/AddDoctorResponse")]
        System.Threading.Tasks.Task<bool> AddDoctorAsync(CMD.Appointments.Repository.DoctorService.Doctor doctor);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IDoctorService/GetAllDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetAllDoctorsResponse")]
        CMD.Appointments.Repository.DoctorService.Doctor[] GetAllDoctors();
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IDoctorService/GetAllDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetAllDoctorsResponse")]
        System.Threading.Tasks.Task<CMD.Appointments.Repository.DoctorService.Doctor[]> GetAllDoctorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IDoctorService/GetDoctorByNpiNo", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorByNpiNoResponse")]
        CMD.Appointments.Repository.DoctorService.Doctor GetDoctorByNpiNo(string npiNo);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IDoctorService/GetDoctorByNpiNo", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorByNpiNoResponse")]
        System.Threading.Tasks.Task<CMD.Appointments.Repository.DoctorService.Doctor> GetDoctorByNpiNoAsync(string npiNo);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IDoctorService/UpdateDoctor", ReplyAction="http://tempuri.org/IDoctorService/UpdateDoctorResponse")]
        bool UpdateDoctor(CMD.Appointments.Repository.DoctorService.Doctor doctor, string npiNo);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IDoctorService/UpdateDoctor", ReplyAction="http://tempuri.org/IDoctorService/UpdateDoctorResponse")]
        System.Threading.Tasks.Task<bool> UpdateDoctorAsync(CMD.Appointments.Repository.DoctorService.Doctor doctor, string npiNo);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IDoctorService/RemoveDoctor", ReplyAction="http://tempuri.org/IDoctorService/RemoveDoctorResponse")]
        bool RemoveDoctor(string npiNo);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/IDoctorService/RemoveDoctor", ReplyAction="http://tempuri.org/IDoctorService/RemoveDoctorResponse")]
        System.Threading.Tasks.Task<bool> RemoveDoctorAsync(string npiNo);
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IDoctorService/SignOut", ReplyAction="http://tempuri.org/IDoctorService/SignOutResponse")]
        bool SignOut();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IDoctorService/SignOut", ReplyAction="http://tempuri.org/IDoctorService/SignOutResponse")]
        System.Threading.Tasks.Task<bool> SignOutAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDoctorServiceChannel : CMD.Appointments.Repository.DoctorService.IDoctorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DoctorServiceClient : System.ServiceModel.ClientBase<CMD.Appointments.Repository.DoctorService.IDoctorService>, CMD.Appointments.Repository.DoctorService.IDoctorService {
        
        public DoctorServiceClient() {
        }
        
        public DoctorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DoctorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ValidateDoctor(string emailId, string password) {
            return base.Channel.ValidateDoctor(emailId, password);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateDoctorAsync(string emailId, string password) {
            return base.Channel.ValidateDoctorAsync(emailId, password);
        }
        
        public bool AddDoctor(CMD.Appointments.Repository.DoctorService.Doctor doctor) {
            return base.Channel.AddDoctor(doctor);
        }
        
        public System.Threading.Tasks.Task<bool> AddDoctorAsync(CMD.Appointments.Repository.DoctorService.Doctor doctor) {
            return base.Channel.AddDoctorAsync(doctor);
        }
        
        public CMD.Appointments.Repository.DoctorService.Doctor[] GetAllDoctors() {
            return base.Channel.GetAllDoctors();
        }
        
        public System.Threading.Tasks.Task<CMD.Appointments.Repository.DoctorService.Doctor[]> GetAllDoctorsAsync() {
            return base.Channel.GetAllDoctorsAsync();
        }
        
        public CMD.Appointments.Repository.DoctorService.Doctor GetDoctorByNpiNo(string npiNo) {
            return base.Channel.GetDoctorByNpiNo(npiNo);
        }
        
        public System.Threading.Tasks.Task<CMD.Appointments.Repository.DoctorService.Doctor> GetDoctorByNpiNoAsync(string npiNo) {
            return base.Channel.GetDoctorByNpiNoAsync(npiNo);
        }
        
        public bool UpdateDoctor(CMD.Appointments.Repository.DoctorService.Doctor doctor, string npiNo) {
            return base.Channel.UpdateDoctor(doctor, npiNo);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateDoctorAsync(CMD.Appointments.Repository.DoctorService.Doctor doctor, string npiNo) {
            return base.Channel.UpdateDoctorAsync(doctor, npiNo);
        }
        
        public bool RemoveDoctor(string npiNo) {
            return base.Channel.RemoveDoctor(npiNo);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveDoctorAsync(string npiNo) {
            return base.Channel.RemoveDoctorAsync(npiNo);
        }
        
        public bool SignOut() {
            return base.Channel.SignOut();
        }
        
        public System.Threading.Tasks.Task<bool> SignOutAsync() {
            return base.Channel.SignOutAsync();
        }
    }
}
