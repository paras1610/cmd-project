//using CMDFrontend.ServiceFacade;
using CMDFrontend.Doctor.Business;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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

namespace CMDFrontend.Doctor.View
{
    /// <summary>
    /// Interaction logic for DocSignUp.xaml
    /// </summary>
    public partial class DocSignUp : Window
    {
        public DocSignUp()
        {
            SizeChanged += (o, e) =>
            {
                var r = SystemParameters.WorkArea;
                Left = r.Right - ActualWidth;
                Top = r.Bottom - ActualHeight;
            };
            InitializeComponent();
        }

       

        public void AddDoctor(object sender, RoutedEventArgs e)
        {
            DoctorBusiness business = new DoctorBusiness();

            ServiceFacade.DoctorService.Doctor doct = new ServiceFacade.DoctorService.Doctor();
            doct.Name = DoctorName.Text;
            doct.PhoneNo = DoctorMobileNumber.Text;
            doct.NpiNo = DoctorNpiNumber.Text;
            doct.Gender = DoctorGender.Text.ToString();
            doct.Password = DoctorPassword.Text;
            doct.PracticeLocation = DoctorPassword.Text;
            doct.Speciality = DoctorSpeciality.Text;
            doct.EmailId = DoctorEmail.Text;
            doct.Image = DocImageURL.Text;
            string cpassword = DoctorConfirmPassword.Password.ToString();
            this.Close();
            
            if (business.AddDoctor(doct))
            { MessageBox.Show("Sign Up Successfull"); }
            else 
            { MessageBox.Show("error occured pls try again"); }


        }

        private void Image_check_CLick(object sender, RoutedEventArgs e)
        {
            Business.DoctorBusiness business = new DoctorBusiness();
            BitmapImage img= business.ImageConverter(DocImageURL.Text);
            docuploadimage.Source = img;
        }
    }
}
