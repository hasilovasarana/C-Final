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
    public partial class Group_TypesForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        public Group_TypesForm()
        {
            InitializeComponent();
            fillScheduleCmb();
        }

       

        private void save_group_types_Click(object sender, EventArgs e)
        {
            int groupScheduleId = db.Group_Schedule.Where(g_sched => g_sched.group_schedule_name== this.group_schedule_cmb.Text).First().Id;
            var groupTypeName = group_type.Text;
            Group_Types group_Types = new Group_Types();
            group_Types.group_type_name = groupTypeName;
            group_Types.group_schedule_id = groupScheduleId;
            db.Group_Types.Add(group_Types);
            db.SaveChanges();
        }
        private void fillScheduleCmb()
        {
            this.group_schedule_cmb.Items.Clear();
            List<Group_Schedule> scheduleList = db.Group_Schedule.ToList();
            foreach (Group_Schedule item in scheduleList)
            {
                group_schedule_cmb.Items.Add(item.group_schedule_name);
            }
        }

  
    }
}
