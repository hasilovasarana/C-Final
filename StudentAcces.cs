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
    public partial class StudentAcces : Form
    {
        EntitiesModel db = new EntitiesModel();
        public static int current_student_id;
        public StudentAcces()
        {
            InitializeComponent();
        }

        private void StudentAcces_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'programing_StudentDataSet1.Students' table. You can move, or remove it, as needed.
            //this.studentsTableAdapter.Fill(this.programing_StudentDataSet1.Students);
            var student_info = db.Students.Where(s => s.Id == current_student_id).ToList();
            student_own_data_gridview.DataSource = student_info;


        }
    }
}
