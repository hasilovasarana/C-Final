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
    public partial class MentorsDataForm : Form
    {
        EntitiesModel db = new EntitiesModel();
        public MentorsDataForm()
        {
            InitializeComponent();
            fillMentor();
        }

        private void MentorsDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'programing_StudentDataSet3.Mentors' table. You can move, or remove it, as needed.
            this.mentorsTableAdapter.Fill(this.programing_StudentDataSet3.Mentors);

        }

        private void delete_mentor_Click(object sender, EventArgs e)
        {
            List<Mentor> mentorList = db.Mentors.ToList();
            for (int i = 0; i < mentorList.Count; i++)
            {
                if (mentorList[i].Id==Convert.ToInt32(delete_mentor_cmb.SelectedItem))
                {
                    db.Mentors.Remove(mentorList[i]);
                    db.SaveChanges();
                }
            }
        }

        private void fillMentor()
        {
            this.delete_mentor_cmb.Items.Clear();
            List<Mentor> mentorList = db.Mentors.ToList();
            foreach (Mentor mentorItem in mentorList)
            {
                delete_mentor_cmb.Items.Add(mentorItem.Id);
            }
        }
    }
}
