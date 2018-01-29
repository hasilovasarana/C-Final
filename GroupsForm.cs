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
    public partial class GroupsForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        public GroupsForm()
        {
            InitializeComponent();
            fillGroupTypeCmb();
            fillMentorCmb();
            fillTeacherCmb();
        }

        

        private void Go_Group_Types_Click(object sender, EventArgs e)
        {
            Group_TypesForm group_TypesForm = new Group_TypesForm();
            group_TypesForm.ShowDialog();
        }

        private void save_group_Click(object sender, EventArgs e)
        {
            int groupTypeId = db.Group_Types.Where(gt => gt.group_type_name == this.group_type_cmb.Text).First().Id;
            int teacherId = db.Teachers.Where(t => t.teacher_name == this.group_teacher_cmb.Text).First().Id;
            int mentorId = db.Mentors.Where(m => m.mentor_name == this.group_mentor_cmb.Text).First().Id;
            var groupName = group_name.Text;
            var groupStartDate = Convert.ToString(group_start_date.Value);
            string subStart = groupStartDate.Substring(0, 10);
            Group group = new Group();
            group.group_name = groupName;
            group.group_type_id = groupTypeId;
            group.group_teacher_id = teacherId;
            group.group_mentor_id = mentorId;
            group.group_start_date = subStart;
            db.Groups.Add(group);
            db.SaveChanges();
        }
        private void fillGroupTypeCmb()
        {
            this.group_type_cmb.Items.Clear();
            List<Group_Types> group_typeList = db.Group_Types.ToList();
            foreach (Group_Types groupTypeItem in group_typeList)
            {
                group_type_cmb.Items.Add(groupTypeItem.group_type_name);
            }
        }
        private void fillTeacherCmb()
        {
            this.group_teacher_cmb.Items.Clear();
            List<Teacher> teacherList = db.Teachers.ToList();
            foreach (Teacher teacherItem in teacherList)
            {
                group_teacher_cmb.Items.Add(teacherItem.teacher_name);
            }
        }
        private void fillMentorCmb()
        {
            this.group_mentor_cmb.Items.Clear();
            List<Mentor> mentorList = db.Mentors.ToList();
            foreach (Mentor mentorItem in mentorList)
            {
                group_mentor_cmb.Items.Add(mentorItem.mentor_name);
            }
        }

    }
}
