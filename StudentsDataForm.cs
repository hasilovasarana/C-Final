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
    public partial class StudentsDataForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        public StudentsDataForm()
        {
            InitializeComponent();
            fillStudent();
        }

        private void delete_student_Click(object sender, EventArgs e)
        {
            List<Student> list = db.Students.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id==Convert.ToInt32(delete_student_cmb.SelectedItem))
                {
                    db.Students.Remove(list[i]);
                    db.SaveChanges();
                }
            }

        }
        private void fillStudent()
        {
            this.delete_student_cmb.Items.Clear();
            List<Student> deleteList = db.Students.ToList();
            foreach (Student items in deleteList)
            {
                delete_student_cmb.Items.Add(items.Id);
            }
        }

        private void StudentsDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'programing_StudentDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.programing_StudentDataSet.Students);

        }
    }
}
