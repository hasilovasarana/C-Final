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
    public partial class MentorsForm : Form
    {
        EntitiesModel db = new EntitiesModel();

        OpenFileDialog fileDialog = new OpenFileDialog();

        public MentorsForm()
        {
            InitializeComponent();
            fillMentorGenderCmb();
        }

        private void save_mentor_Click(object sender, EventArgs e)
        {
            int genderId = db.Genders.Where(g => g.gender_name == this.mentor_gender_cmb.Text).First().Id;
            var mentorName = mentor_name.Text;
            var mentorSurname = mentor_surname.Text;
            var mentorEmail = mentor_email.Text;
            var mentorInfo = mentor_info.Text;
            var mentorPassword = mentor_password.Text;
            Mentor mentor = new Mentor();

            fileDialog.ShowDialog();
            mentor_picture.Image = Image.FromFile(fileDialog.FileName);
            fileDialog.Filter = "jpeg files(*.jpg)|*.jpg|png files(*.png)|*.png|all files(*.*)|*.*";
            string mentorImageName = DateTime.Now.ToString("yyyymmddssHHMM") + fileDialog.SafeFileName;
            string UploadPath = @"C:\Users\Taleh\source\repos\Code_AcademyForm\Code_AcademyForm\Mentor\";
            
            UploadPath += mentorImageName;
            WebClient web = new WebClient();
            web.DownloadFile(fileDialog.FileName, UploadPath);

            mentor.mentor_name = mentorName;
            mentor.mentor_surname = mentorSurname;
            mentor.mentor_email = mentorEmail;
            mentor.mentor_password = mentorPassword;
            mentor.mentor_info = mentorInfo;
            mentor.mentor_photo = UploadPath;
            mentor.mentor_gender_id = genderId;
            db.Mentors.Add(mentor);
            db.SaveChanges();
        }
        private void fillMentorGenderCmb()
        {
            this.mentor_gender_cmb.Items.Clear();
            List<Gender> genderList = db.Genders.ToList();
            foreach (Gender item in genderList)
            {
                mentor_gender_cmb.Items.Add(item.gender_name);
            }
        }



        private void show_mentor_data_Click(object sender, EventArgs e)
        {
            MentorsDataForm mentorsDataForm = new MentorsDataForm();
            mentorsDataForm.ShowDialog();
        }

        private void go_update_mentor_Click(object sender, EventArgs e)
        {
            UpdateMentorData updateMentorData = new UpdateMentorData();
            updateMentorData.ShowDialog();
        }
    }
}
