using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_AcademyForm
{
    public partial class AdminForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        public AdminForm()
        {
            InitializeComponent();
         
        }       

        private void login_Click(object sender, EventArgs e)            
        {
            if (username.Text == "admin" && password.Text == "123")
            {
                AcademyForm academyForm = new AcademyForm();
                academyForm.ShowDialog();
            }
            var queryTeacher = db.Teachers.Where(t => t.teacher_email == this.username.Text && t.teacher_password == this.password.Text);
            if (queryTeacher.Count()>0)
            {

                TeacherAcces teacherAcces = new TeacherAcces();
                teacherAcces.ShowDialog();
            

            }
            var queryMentor = db.Mentors.Where(m => m.mentor_email == this.username.Text && m.mentor_password == this.password.Text);
            if (queryMentor.Count()>0)
            {
             
                MentorsForm mentorsForm = new MentorsForm();
                mentorsForm.ShowDialog();
            }
            var queryStudent = db.Students.Where(s => s.student_email == this.username.Text && s.student_password == this.password.Text);
            if (queryStudent.Count()>0)
            {
                foreach (var item in queryStudent.ToList())
                {
                    StudentAcces.current_student_id = item.Id;
                }
                StudentAcces studentAcces = new StudentAcces();                
                studentAcces.ShowDialog();
            }
            else
            {
                
                username.Text = " ";
                password.Text = " ";
            }
        }
               
     
       

       
    }
}
