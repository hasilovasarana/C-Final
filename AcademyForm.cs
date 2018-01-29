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
    public partial class AcademyForm : Form
    {
        EntitiesModel db = new EntitiesModel();

        public AcademyForm()
        {
            InitializeComponent();
        }

        private void go_to_students_Click(object sender, EventArgs e)
        {

            StudentsForm students = new StudentsForm();
            students.ShowDialog();
        }

        private void go_to_teachers_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.ShowDialog();
        }

        private void go_to_mentors_Click(object sender, EventArgs e)
        {
            MentorsForm mentorsForm = new MentorsForm();
            mentorsForm.ShowDialog();
        }

        private void go_to_groups_Click(object sender, EventArgs e)
        {
            GroupsForm groupsForm = new GroupsForm();
            groupsForm.ShowDialog();

        }

        private void go_to_group_types_Click(object sender, EventArgs e)
        {
            Group_TypesForm group_TypesForm = new Group_TypesForm();
            group_TypesForm.ShowDialog();
        }

        private void go_to_group_schedule_Click(object sender, EventArgs e)
        {
            Group_ScheduleForm group_ScheduleForm = new Group_ScheduleForm();
            group_ScheduleForm.ShowDialog();
        }

        private void go_to_tasks_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm();
            tasksForm.ShowDialog();
        }

        private void go_to_task_types_Click(object sender, EventArgs e)
        {
            Task_TypesForm task_TypesForm = new Task_TypesForm();
            task_TypesForm.ShowDialog();
        }

        
    }
}
