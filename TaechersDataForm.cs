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
    public partial class TaechersDataForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        public TaechersDataForm()
        {
            InitializeComponent();
            fillTeacherId();
        }

        private void TaechersDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'programing_StudentDataSet2.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.programing_StudentDataSet2.Teacher);

        }

        private void delete_teacher_Click(object sender, EventArgs e)
        {
            List<Teacher> teacherList = db.Teachers.ToList();
            for (int i = 0; i < teacherList.Count; i++)
            {
                if (teacherList[i].Id==Convert.ToInt32(teacher_id_cmb.SelectedItem))
                {
                    db.Teachers.Remove(teacherList[i]);
                    db.SaveChanges();
                }
            }
        }
        private void fillTeacherId()
        {
            this.teacher_id_cmb.Items.Clear();
            List<Teacher> teacherList = db.Teachers.ToList();
            foreach (Teacher teacherItem in teacherList)
            {
                teacher_id_cmb.Items.Add(teacherItem.Id);

            }
        }
    }
}
