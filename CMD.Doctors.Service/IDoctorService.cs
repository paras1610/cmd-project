using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CMD.Doctors.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IDoctorService
    {

        
        [OperationContract]
        bool ValidateDoctor(String emailId, String password);
    
        [OperationContract]
        bool AddDoctor(Doctor doctor); //at time of sign up

        [OperationContract]
        List<Doctor> GetAllDoctors();

        [OperationContract]
        Doctor GetDoctorByNpiNo(String npiNo);


        [OperationContract]
        Doctor GetDoctorByEmailid(String Emailid);

        [OperationContract]
        List<Doctor> GetDoctorsByNpiNos(List<String> npiNos);

        [OperationContract]

        bool UpdateDoctor(Doctor doctor, String npiNo);

        [OperationContract]
        bool RemoveDoctor(String npiNo);

        [OperationContract]
        bool SignOut();
    }
}
