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
    public partial class TeacherAcces : Form
    {
        EntitiesModel EntitiesModel = new EntitiesModel();
       
        public TeacherAcces()
        {
            InitializeComponent();
        }

        private void show_students_Click(object sender, EventArgs e)
        {
            StudentAcces studentAcces = new StudentAcces();
            studentAcces.ShowDialog();
        }
    }
}
