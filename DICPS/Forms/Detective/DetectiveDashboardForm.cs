using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICPS.Forms.Detective
{
    public partial class DetectiveDashboardForm : Form
    {
        public DetectiveDashboardForm()
        {
            InitializeComponent();
        }

        private void DetectiveDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btncaseload_Click(object sender, EventArgs e)
        {
            btncaseloadform caseloadForm = new btncaseloadform();
            caseloadForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnsperson_Click(object sender, EventArgs e)
        {
            PersonSearchForm personForm = new PersonSearchForm();
            personForm.Show();
        }

        private void btnrgperson_Click(object sender, EventArgs e)
        {
            RegisterPersonForm registerPersonForm = new RegisterPersonForm();
            registerPersonForm.Show();
        }
    }
}
