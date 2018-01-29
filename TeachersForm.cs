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
    public partial class TeachersForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        OpenFileDialog Dialog = new OpenFileDialog();
        public TeachersForm()
        {
            InitializeComponent();
            fillTeacherGender();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var teacherGenderId = db.Genders.Where(g => g.gender_name == this.teacher_gender_cmb.Text).First().Id;
            Dialog.ShowDialog();
            teacher_picture.Image = Image.FromFile(Dialog.FileName);
            Dialog.Filter = "@jpeg files(*.jpg)|*.jpg|png files(*.png)|*.png|all files(*.*)|*.*";
            string teacherImageName = DateTime.Now.ToString("yyyymmddssHHmm") + Dialog.SafeFileName;
            string UploadPath = @"C:\Users\Taleh\source\repos\Code_AcademyForm\Code_AcademyForm\Teacher\";
            UploadPath += teacherImageName;
            WebClient client = new WebClient();
            client.DownloadFile(Dialog.FileName, UploadPath);
            var teacherName = teacher_name.Text;
            var teacherSurname = teacher_surname.Text;
            var teacherEmail = teacher_email.Text;
            var teacherPassword = teacher_password.Text;
            Teacher teacher = new Teacher();
            teacher.teacher_name = teacherName;
            teacher.teacher_surname = teacherSurname;
            teacher.teacher_email = teacherEmail;
            teacher.teacher_phone = teacher_phone.Text;
            teacher.teacher_password = teacherPassword;
            teacher.teacher_photo = UploadPath;
            teacher.teacher_gender_id = teacherGenderId;
            db.Teachers.Add(teacher);
            db.SaveChanges();
            
        }
        private void fillTeacherGender()
        {
            this.teacher_gender_cmb.Items.Clear();
            List<Gender> genderList = db.Genders.ToList();
            foreach (Gender item in genderList)
            {
                teacher_gender_cmb.Items.Add(item.gender_name);
            }
        }

        private void show_teacher_Click(object sender, EventArgs e)
        {
            TaechersDataForm dataForm = new TaechersDataForm();
            dataForm.ShowDialog();
        }
    }
}
