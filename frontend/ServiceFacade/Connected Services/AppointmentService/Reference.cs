﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceFacade.AppointmentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AppointmentDTO", Namespace="http://schemas.datacontract.org/2004/07/CMD.Appointments.DTOs")]
    [System.SerializableAttribute()]
    public partial class AppointmentDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Appointment_statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IssueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonForVisitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeSlotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string doctorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string patientIdField;
        
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
        public string Appointment_status {
            get {
                return this.Appointment_statusField;
            }
            set {
                if ((object.ReferenceEquals(this.Appointment_statusField, value) != true)) {
                    this.Appointment_statusField = value;
                    this.RaisePropertyChanged("Appointment_status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Issue {
            get {
                return this.IssueField;
            }
            set {
                if ((object.ReferenceEquals(this.IssueField, value) != true)) {
                    this.IssueField = value;
                    this.RaisePropertyChanged("Issue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReasonForVisit {
            get {
                return this.ReasonForVisitField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonForVisitField, value) != true)) {
                    this.ReasonForVisitField = value;
                    this.RaisePropertyChanged("ReasonForVisit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TimeSlot {
            get {
                return this.TimeSlotField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeSlotField, value) != true)) {
                    this.TimeSlotField = value;
                    this.RaisePropertyChanged("TimeSlot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string doctorId {
            get {
                return this.doctorIdField;
            }
            set {
                if ((object.ReferenceEquals(this.doctorIdField, value) != true)) {
                    this.doctorIdField = value;
                    this.RaisePropertyChanged("doctorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string patientId {
            get {
                return this.patientIdField;
            }
            set {
                if ((object.ReferenceEquals(this.patientIdField, value) != true)) {
                    this.patientIdField = value;
                    this.RaisePropertyChanged("patientId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PrescriptionDTO", Namespace="http://schemas.datacontract.org/2004/07/CMD.Appointments.DTOs")]
    [System.SerializableAttribute()]
    public partial class PrescriptionDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long App_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DurationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsBeforeFoodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Medicine_DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Medicine_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Medicine_cycleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public long App_Id {
            get {
                return this.App_IdField;
            }
            set {
                if ((this.App_IdField.Equals(value) != true)) {
                    this.App_IdField = value;
                    this.RaisePropertyChanged("App_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Duration {
            get {
                return this.DurationField;
            }
            set {
                if ((object.ReferenceEquals(this.DurationField, value) != true)) {
                    this.DurationField = value;
                    this.RaisePropertyChanged("Duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsBeforeFood {
            get {
                return this.IsBeforeFoodField;
            }
            set {
                if ((this.IsBeforeFoodField.Equals(value) != true)) {
                    this.IsBeforeFoodField = value;
                    this.RaisePropertyChanged("IsBeforeFood");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Medicine_Description {
            get {
                return this.Medicine_DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.Medicine_DescriptionField, value) != true)) {
                    this.Medicine_DescriptionField = value;
                    this.RaisePropertyChanged("Medicine_Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Medicine_Name {
            get {
                return this.Medicine_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Medicine_NameField, value) != true)) {
                    this.Medicine_NameField = value;
                    this.RaisePropertyChanged("Medicine_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Medicine_cycle {
            get {
                return this.Medicine_cycleField;
            }
            set {
                if ((object.ReferenceEquals(this.Medicine_cycleField, value) != true)) {
                    this.Medicine_cycleField = value;
                    this.RaisePropertyChanged("Medicine_cycle");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AppointmentService.IAppointmentService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IAppointmentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/AddAppointment", ReplyAction="http://tempuri.org/IAppointmentService/AddAppointmentResponse")]
        bool AddAppointment(ServiceFacade.AppointmentService.AppointmentDTO appointment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/AddAppointment", ReplyAction="http://tempuri.org/IAppointmentService/AddAppointmentResponse")]
        System.Threading.Tasks.Task<bool> AddAppointmentAsync(ServiceFacade.AppointmentService.AppointmentDTO appointment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/getAppointmentById", ReplyAction="http://tempuri.org/IAppointmentService/getAppointmentByIdResponse")]
        ServiceFacade.AppointmentService.AppointmentDTO[] getAppointmentById(long App_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/getAppointmentById", ReplyAction="http://tempuri.org/IAppointmentService/getAppointmentByIdResponse")]
        System.Threading.Tasks.Task<ServiceFacade.AppointmentService.AppointmentDTO[]> getAppointmentByIdAsync(long App_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/getAllAppointmentsOfDoctor", ReplyAction="http://tempuri.org/IAppointmentService/getAllAppointmentsOfDoctorResponse")]
        ServiceFacade.AppointmentService.AppointmentDTO[] getAllAppointmentsOfDoctor(string Doc_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/getAllAppointmentsOfDoctor", ReplyAction="http://tempuri.org/IAppointmentService/getAllAppointmentsOfDoctorResponse")]
        System.Threading.Tasks.Task<ServiceFacade.AppointmentService.AppointmentDTO[]> getAllAppointmentsOfDoctorAsync(string Doc_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/getAllAppointmentsOfPatient", ReplyAction="http://tempuri.org/IAppointmentService/getAllAppointmentsOfPatientResponse")]
        ServiceFacade.AppointmentService.AppointmentDTO[] getAllAppointmentsOfPatient(string Pat_Emailid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/getAllAppointmentsOfPatient", ReplyAction="http://tempuri.org/IAppointmentService/getAllAppointmentsOfPatientResponse")]
        System.Threading.Tasks.Task<ServiceFacade.AppointmentService.AppointmentDTO[]> getAllAppointmentsOfPatientAsync(string Pat_Emailid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/getAllAppointmentsAccToStatus", ReplyAction="http://tempuri.org/IAppointmentService/getAllAppointmentsAccToStatusResponse")]
        ServiceFacade.AppointmentService.AppointmentDTO[] getAllAppointmentsAccToStatus(string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/getAllAppointmentsAccToStatus", ReplyAction="http://tempuri.org/IAppointmentService/getAllAppointmentsAccToStatusResponse")]
        System.Threading.Tasks.Task<ServiceFacade.AppointmentService.AppointmentDTO[]> getAllAppointmentsAccToStatusAsync(string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/SetAppointmentStatus", ReplyAction="http://tempuri.org/IAppointmentService/SetAppointmentStatusResponse")]
        bool SetAppointmentStatus(string app_id, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/SetAppointmentStatus", ReplyAction="http://tempuri.org/IAppointmentService/SetAppointmentStatusResponse")]
        System.Threading.Tasks.Task<bool> SetAppointmentStatusAsync(string app_id, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/ShowAllPrescripton", ReplyAction="http://tempuri.org/IAppointmentService/ShowAllPrescriptonResponse")]
        ServiceFacade.AppointmentService.PrescriptionDTO[] ShowAllPrescripton(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/ShowAllPrescripton", ReplyAction="http://tempuri.org/IAppointmentService/ShowAllPrescriptonResponse")]
        System.Threading.Tasks.Task<ServiceFacade.AppointmentService.PrescriptionDTO[]> ShowAllPrescriptonAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/EditPrescription", ReplyAction="http://tempuri.org/IAppointmentService/EditPrescriptionResponse")]
        bool EditPrescription(ServiceFacade.AppointmentService.PrescriptionDTO prescription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/EditPrescription", ReplyAction="http://tempuri.org/IAppointmentService/EditPrescriptionResponse")]
        System.Threading.Tasks.Task<bool> EditPrescriptionAsync(ServiceFacade.AppointmentService.PrescriptionDTO prescription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/AddPrescription", ReplyAction="http://tempuri.org/IAppointmentService/AddPrescriptionResponse")]
        bool AddPrescription(ServiceFacade.AppointmentService.PrescriptionDTO prescription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/AddPrescription", ReplyAction="http://tempuri.org/IAppointmentService/AddPrescriptionResponse")]
        System.Threading.Tasks.Task<bool> AddPrescriptionAsync(ServiceFacade.AppointmentService.PrescriptionDTO prescription);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAppointmentServiceChannel : ServiceFacade.AppointmentService.IAppointmentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AppointmentServiceClient : System.ServiceModel.ClientBase<ServiceFacade.AppointmentService.IAppointmentService>, ServiceFacade.AppointmentService.IAppointmentService {
        
        public AppointmentServiceClient() {
        }
        
        public AppointmentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AppointmentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppointmentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppointmentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddAppointment(ServiceFacade.AppointmentService.AppointmentDTO appointment) {
            return base.Channel.AddAppointment(appointment);
        }
        
        public System.Threading.Tasks.Task<bool> AddAppointmentAsync(ServiceFacade.AppointmentService.AppointmentDTO appointment) {
            return base.Channel.AddAppointmentAsync(appointment);
        }
        
        public ServiceFacade.AppointmentService.AppointmentDTO[] getAppointmentById(long App_id) {
            return base.Channel.getAppointmentById(App_id);
        }
        
        public System.Threading.Tasks.Task<ServiceFacade.AppointmentService.AppointmentDTO[]> getAppointmentByIdAsync(long App_id) {
            return base.Channel.getAppointmentByIdAsync(App_id);
        }
        
        public ServiceFacade.AppointmentService.AppointmentDTO[] getAllAppointmentsOfDoctor(string Doc_id) {
            return base.Channel.getAllAppointmentsOfDoctor(Doc_id);
        }
        
        public System.Threading.Tasks.Task<ServiceFacade.AppointmentService.AppointmentDTO[]> getAllAppointmentsOfDoctorAsync(string Doc_id) {
            return base.Channel.getAllAppointmentsOfDoctorAsync(Doc_id);
        }
        
        public ServiceFacade.AppointmentService.AppointmentDTO[] getAllAppointmentsOfPatient(string Pat_Emailid) {
            return base.Channel.getAllAppointmentsOfPatient(Pat_Emailid);
        }
        
        public System.Threading.Tasks.Task<ServiceFacade.AppointmentService.AppointmentDTO[]> getAllAppointmentsOfPatientAsync(string Pat_Emailid) {
            return base.Channel.getAllAppointmentsOfPatientAsync(Pat_Emailid);
        }
        
        public ServiceFacade.AppointmentService.AppointmentDTO[] getAllAppointmentsAccToStatus(string status) {
            return base.Channel.getAllAppointmentsAccToStatus(status);
        }
        
        public System.Threading.Tasks.Task<ServiceFacade.AppointmentService.AppointmentDTO[]> getAllAppointmentsAccToStatusAsync(string status) {
            return base.Channel.getAllAppointmentsAccToStatusAsync(status);
        }
        
        public bool SetAppointmentStatus(string app_id, string status) {
            return base.Channel.SetAppointmentStatus(app_id, status);
        }
        
        public System.Threading.Tasks.Task<bool> SetAppointmentStatusAsync(string app_id, string status) {
            return base.Channel.SetAppointmentStatusAsync(app_id, status);
        }
        
        public ServiceFacade.AppointmentService.PrescriptionDTO[] ShowAllPrescripton(long id) {
            return base.Channel.ShowAllPrescripton(id);
        }
        
        public System.Threading.Tasks.Task<ServiceFacade.AppointmentService.PrescriptionDTO[]> ShowAllPrescriptonAsync(long id) {
            return base.Channel.ShowAllPrescriptonAsync(id);
        }
        
        public bool EditPrescription(ServiceFacade.AppointmentService.PrescriptionDTO prescription) {
            return base.Channel.EditPrescription(prescription);
        }
        
        public System.Threading.Tasks.Task<bool> EditPrescriptionAsync(ServiceFacade.AppointmentService.PrescriptionDTO prescription) {
            return base.Channel.EditPrescriptionAsync(prescription);
        }
        
        public bool AddPrescription(ServiceFacade.AppointmentService.PrescriptionDTO prescription) {
            return base.Channel.AddPrescription(prescription);
        }
        
        public System.Threading.Tasks.Task<bool> AddPrescriptionAsync(ServiceFacade.AppointmentService.PrescriptionDTO prescription) {
            return base.Channel.AddPrescriptionAsync(prescription);
        }
    }
}
