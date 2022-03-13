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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student student {
            get { return student; }
            set { student = value;
                PrintOutStudent();

            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }


        private void PrintOutStudent()
        {
            if(student == null)
            {
                CleanAll();
                BlockControls();
            }
            else
            {
                ActivateControls();
                PrintStudent(student);
            }
        }

        private void CleanAll()
        {
            Name.Text = "";
            Surname.Text = "";
            Family.Text = "";
            Faculty.Text = "";
            Speciality.Text = "";
            Degree.Text = "";
            Status.Text = "";
            FacNum.Text = "";
            Course.Text = "";
            Stream.Text = "";
            Course.Text = "";
        }

        private void PrintStudent(Student student)
        {
            Name.Text = student.Name;
            Surname.Text = student.Surname;
            Family.Text = student.Family;
            Faculty.Text = student.Faculty;
            Speciality.Text = student.Speciality;
            Degree.Text = student.Degree;
            Status.Text = student.Status;
            FacNum.Text = student.FacNum;
            Course.Text = student.Course.ToString();
            Stream.Text = student.Stream.ToString();
            Course.Text = student.Course.ToString();
        }


        private void BlockControls()
        {
            Name.IsEnabled=false;
            Surname.IsEnabled = false;
            Family.IsEnabled = false;
            Faculty.IsEnabled = false;
            Speciality.IsEnabled = false;
            Degree.IsEnabled = false;
            Status.IsEnabled = false;
            FacNum.IsEnabled = false;
            Course.IsEnabled = false;
            Stream.IsEnabled = false;
            Course.IsEnabled = false;
        }

        private void ActivateControls()
        {
            Name.IsEnabled = true;
            Surname.IsEnabled = true;
            Family.IsEnabled = true;
            Faculty.IsEnabled = true;
            Speciality.IsEnabled = true;
            Degree.IsEnabled = true;
            Status.IsEnabled = true;
            FacNum.IsEnabled = true;
            Course.IsEnabled = true;
            Stream.IsEnabled = true;
            Course.IsEnabled = true;
        }
    }
}
