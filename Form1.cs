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
    public partial class Form1 : Form
    {
        EntitiesModel db = new EntitiesModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
