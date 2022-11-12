using CMDFrontend.Doctor.Business;
using CMDFrontend.Doctor.View;
using CMDFrontend.Patient.Model;
using CMDFrontend.Patient.Model.Business;
using CMDFrontend.Patient.View;
using ServiceFacade;
//using CMDFrontend.ServiceFacade;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CMDFrontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoctorLogIn(object sender, RoutedEventArgs e)
        {
            DoctorBusiness doctor = new DoctorBusiness();
            doctor.DoctorLogin(UsernameTextBox.Text, PasswordBox.Password.ToString());
            this.Close();
           

        }

        private void PatientLogIn(object sender, RoutedEventArgs e)
        {
            PatientBusiness patient = new PatientBusiness();
            patient.PatientLogin(UsernameTextBox.Text, PasswordBox.Password.ToString());                           
            this.Close();
        }

       

        private void pSignInButton(object sender, RoutedEventArgs e)
        {
            PatientSignUpForm patientSignUpForm = new PatientSignUpForm();
            patientSignUpForm.ShowDialog();
        }

        private void dSignInButton(object sender, RoutedEventArgs e)
        {
            DocSignUp docSignUp = new DocSignUp();
            docSignUp.ShowDialog();
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
           
            //Doctor.View.HomePage homePage = new Doctor.View.HomePage();
            //DoctorServiceFacade doctorServiceFacade = new DoctorServiceFacade();
           
            //if (doctorServiceFacade.ValidateDoctor(UsernameTextBox.Text, PasswordBox.Password.ToString()))
            //{
            //    homePage.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Username or password");
            //}

        }
    }
}
