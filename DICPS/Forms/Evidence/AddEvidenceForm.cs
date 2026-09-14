using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICPS.Forms.Evidence
{
    public partial class AddEvidenceForm : Form
    {
        public AddEvidenceForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Do you want to verify this evidence record?",
       "Verify Evidence",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Evidence verified successfully.",
                    "Verification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvidenceForm form = new AddEvidenceForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateEvidenceForm form = new UpdateEvidenceForm();
            form.Show();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to delete this evidence record?",
        "Delete Evidence",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Evidence record deleted successfully.");
            }
        }
    }
}
