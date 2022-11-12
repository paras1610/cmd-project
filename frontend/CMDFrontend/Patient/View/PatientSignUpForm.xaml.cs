//using CMDFrontend.PatientServiceNS;
//using CMDFrontend.ServiceFacade;
using CMDFrontend.Doctor.Business;
using CMDFrontend.Patient.Model.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CMDFrontend.Patient.View
{
    /// <summary>
    /// Interaction logic for PatientSignUpForm.xaml
    /// </summary>
    public partial class PatientSignUpForm : Window
    {
        public PatientSignUpForm()
        {
            InitializeComponent();
        }

      

        private void AddPatient(object sender, RoutedEventArgs e)
        {
            ServiceFacade.PatientService.Patient pat = new ServiceFacade.PatientService.Patient();

            pat.Name = PatientName.Text;
            pat.Gender = PatientGender.Text;
            pat.Location = PatientCity+","+ PatientState + "," + PatientCountry.Text ;
            pat.BloodGroup = PatientBloodGroup.Text;
            pat.Password = PatientPassword.Text;
            pat.EmailId = PatientEmail.Text;
            pat.PhoneNumber = PatientMobileNumber.Text;
            pat.Image = PatientImageTB.Text;
            PatientBusiness business = new PatientBusiness();
            if (business.NewPatient(pat))
            {
                this.Close();
                MessageBox.Show("Sign Up Successfull"); 
            }

            else MessageBox.Show("Error occured");
        }

        private void checkpatimagebutton_Click(object sender, RoutedEventArgs e)
        {
            Doctor.Business.DoctorBusiness business = new DoctorBusiness();
            BitmapImage img = business.ImageConverter(PatientImageTB.Text);
            patuploadimage.Source = img;
        }
    }
}
