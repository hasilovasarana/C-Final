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
    public partial class UpdateStudentForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        OpenFileDialog open = new OpenFileDialog();

        public UpdateStudentForm()
        {
            InitializeComponent();
            fillStudentId();
            fillUpdateGender();
        }

        private void update_student_Click(object sender, EventArgs e)
        {
            changeName();
            changeSurname();




        }

        private void changeName()
        {
            //List<Student> studentUpdatetlist = db.Students.ToList();
            //var changeStudentName = (from s in studentUpdatetlist
            //                         where s.student_name == select_student_cmb.SelectedItem.ToString()
            //                         select s).Single();
            //changeStudentName.student_name = update_s_name.Text;
            List<Student> studentUpdatetlist = db.Students.ToList();
            var current = (from s in studentUpdatetlist where s.Id == Convert.ToInt32(select_student_cmb.SelectedItem) select s).SingleOrDefault();
            if (update_s_name.Text != "")
            {
                current.student_name = update_s_name.Text;
            }            
            db.SaveChanges();

        }

        private void changeSurname()
        {
            List<Student> studentUpdatetlist = db.Students.ToList();
            var changeStudentSurname = (from s in studentUpdatetlist
                                        where s.Id == Convert.ToInt32(select_student_cmb.SelectedItem)
                                        select s).Single();
            if (update_s_surname.Text !="")
            {
                changeStudentSurname.student_surname = update_s_surname.Text;
            }
           
            db.SaveChanges();

        }
        private void fillStudentId()
        {
            this.select_student_cmb.Items.Clear();
            List<Student> studentList = db.Students.ToList();
            foreach (Student studentItem in studentList)
            {
                select_student_cmb.Items.Add(studentItem.Id);
            }
        }
        private void fillUpdateGender()
        {
            this.update_gender_cmb.Items.Clear();
            List<Gender> list = db.Genders.ToList();
            foreach (Gender item in list)
            {
                update_gender_cmb.Items.Add(item.gender_name);
            }



        }

   
    }
}
