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
    public partial class Group_ScheduleForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        public Group_ScheduleForm()
        {
            InitializeComponent();
          
        }

       

        private void save_schedule_Click(object sender, EventArgs e)
        {
            
            var scheduleName = group_schedule_name.Text;
            var groupBeginTime =Convert.ToString(group_begin_time.Value);
            string subBegin = groupBeginTime.Substring(10, 10);
            var groupEndTime =  Convert.ToString(group_end_time.Value);
            string subEnd = groupEndTime.Substring(10, 10);
            Group_Schedule group_Schedule = new Group_Schedule();
            group_Schedule.group_schedule_name = scheduleName;
            group_Schedule.group_begin_time = subBegin;
            group_Schedule.group_end_time = subEnd;
            db.Group_Schedule.Add(group_Schedule);
            db.SaveChanges();
        }
    

      
    }
}
