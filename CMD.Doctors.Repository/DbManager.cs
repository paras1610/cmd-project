using CMD.Doctors.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Doctors.Repository
{
    public class DbManager
    {
        DoctorsDbContext dbContext = new DoctorsDbContext();
        public bool AddDoctor(Doctor doctor)
        {
            bool isAdded = false;
            
            try
            {
                SignInDoctor docSignIn = new SignInDoctor();
                docSignIn.emailId = doctor.EmailId;
                docSignIn.password=doctor.Password;

                dbContext.doctorsSignIn.Add(docSignIn);
                dbContext.doctors.Add(doctor);
                dbContext.SaveChanges();
                isAdded = true;
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            return isAdded;
        }

        public bool deleteDoctorById(long id)
        {
            bool isDeleted = false;
            var doctorToBeDeleted = dbContext.doctors.FirstOrDefault(x => x.Id == id);
            if (doctorToBeDeleted != null)
            {
                dbContext.doctors.Remove(doctorToBeDeleted);
                dbContext.SaveChanges();
                isDeleted = true;
            }
            return isDeleted;
        }

        public List<Doctor> getAllDoctors()
        {
            try
            {
                List<Doctor> allPatients = dbContext.doctors.ToList();
                return allPatients;
            }
            catch (Exception) { throw; }
        }

        public Doctor getDoctorById(String id)
        {
            try
            {
                var patient = dbContext.doctors.FirstOrDefault(x => x.NpiNo.Equals(id));
                return patient;
            }
            catch (Exception) { throw; }
        }

        public Doctor getDoctorByEmailId(String id)
        {
           
            try
            {
               var doctor= dbContext.doctors.FirstOrDefault(x => x.EmailId.Equals(id));
               return doctor;
            }
            catch(Exception) { throw; }
           
        }

        public bool updateDoctor(Doctor doctor, string id)
        {
            bool isUpdated = false;
            var doctorToBeUpdated = dbContext.doctors.FirstOrDefault(x => x.NpiNo.Equals(id));
            try
            {
                if (doctorToBeUpdated != null)
                {
                    doctorToBeUpdated.Name = doctor.Name;
                    doctorToBeUpdated.EmailId = doctor.EmailId;
                    doctorToBeUpdated.PhoneNo = doctor.PhoneNo;
                    doctorToBeUpdated.Speciality = doctor.Speciality;

                    doctorToBeUpdated.PracticeLocation = doctor.PracticeLocation;

                    dbContext.SaveChanges();
                    isUpdated = true;
                }
            }
            catch (Exception) { throw; }
            return isUpdated;
        }

        public bool validateDoctorForSignIn(string emailId, string password)
        {
            bool isValid = false;

            var doctorToBeSignedIn = dbContext.doctorsSignIn.FirstOrDefault(x => x.emailId.Equals(emailId));
            if(doctorToBeSignedIn != null && doctorToBeSignedIn.password.Equals(password))
            {
                try
                {
                    isValid = true;
                }
                catch (Exception) { throw; }
              
            }

            return isValid;
        }
    }
}
