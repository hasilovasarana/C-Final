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
    public partial class Task_TypesForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        public Task_TypesForm()
        {
            InitializeComponent();
        }

        private void go_to_tasks_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm();
            tasksForm.ShowDialog();
        }
    }
}
