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
    public partial class EvidenceDashboardForm : Form
    {
        public EvidenceDashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvidenceForm addEvidence = new AddEvidenceForm();
            addEvidence.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChainOfCustodyForm chainForm = new ChainOfCustodyForm();
            chainForm.Show();
        }
    }
}
