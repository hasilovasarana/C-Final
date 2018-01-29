using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_AcademyForm
{
    public partial class StudentsForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        OpenFileDialog OpenFileDialog = new OpenFileDialog();
   
        public StudentsForm()
        {
            InitializeComponent();
            fillStudentGenderCmb();
            fillStudentGroupCmb();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int genderId = db.Genders.Where(g => g.gender_name == this.student_gender_cmb.Text).First().Id;
            int groupId = db.Groups.Where(g_type => g_type.group_name == this.student_group_cmb.Text).First().Id;

            OpenFileDialog.ShowDialog();
            student_picture.Image = Image.FromFile(OpenFileDialog.FileName);
            OpenFileDialog.Filter = "jpeg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            string UploadPath = @"C:\Users\Taleh\source\repos\Code_AcademyForm\Code_AcademyForm\Student\";
            string studentImageName = DateTime.Now.ToString("yyyymmddssHHMM") + OpenFileDialog.SafeFileName;            
            UploadPath += studentImageName;
            WebClient webClient = new WebClient();
            webClient.DownloadFile(OpenFileDialog.FileName, UploadPath);

            var studentName = student_name.Text;
            var studentSurname = student_surname.Text;
            var studentEmail = student_email.Text;
            var studentGithubAccount = student_github_account.Text;
            var studentInfo = student_info.Text;
            var studentPhone = student_phone.Text;
            var studentPassword = student_password.Text;
            var studentCapPoint = Convert.ToDouble(student_cap_point.Text);          
            Student students = new Student();
            students.student_name = studentName;
            students.student_surname = studentSurname;
            students.student_gender_id = genderId;
            students.student_email = studentEmail;
            students.student_phone = studentPhone;
            students.student_github_account = studentGithubAccount;
            students.student_info = studentInfo;
            students.student_photo = UploadPath;
            students.student_password = studentPassword;
            students.student_cap_point = studentCapPoint;
            students.student_group_id = groupId;
            db.Students.Add(students);
            db.SaveChanges();


        }
        private void fillStudentGenderCmb()
        {
            this.student_gender_cmb.Items.Clear();
            List<Gender> genderList = db.Genders.ToList();
            foreach (Gender genderItem in genderList)
            {
                student_gender_cmb.Items.Add(genderItem.gender_name);
            }
        }
        private void fillStudentGroupCmb()
        {
            this.student_group_cmb.Items.Clear();
            List<Group> groupList = db.Groups.ToList();
            foreach (Group groupItem in groupList)
            {
                student_group_cmb.Items.Add(groupItem.group_name);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateStudentForm updateStudentForm = new UpdateStudentForm();
            updateStudentForm.ShowDialog();
        }

        private void show_students_Click(object sender, EventArgs e)
        {
            StudentsDataForm studentsDataForm = new StudentsDataForm();
            studentsDataForm.ShowDialog();
        }
    }
}

