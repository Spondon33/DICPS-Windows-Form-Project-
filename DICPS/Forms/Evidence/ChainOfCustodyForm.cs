using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DICPS.Common;
using DICPS.Models.Evidence;

namespace DICPS.Forms.Evidence
{
    public partial class ChainOfCustodyForm : Form
    {
        private StaffUser loggedInUser;
        private int evidenceId;

        public ChainOfCustodyForm(StaffUser user, int evidenceIdParam)
        {
            InitializeComponent();
            loggedInUser = user;
            evidenceId = evidenceIdParam;
        }

        private void ChainOfCustodyForm_Load(object sender, EventArgs e)
        {
            lblEvidenceId.Text = "Evidence ID: " + evidenceId;
            LoadCustodyLog();
        }

        private void LoadCustodyLog()
        {
            dgvCustodyLog.DataSource = CustodyLog.GetCustodyLogByEvidence(evidenceId);
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                MessageBox.Show("Please enter notes for this custody log entry.");
                return;
            }

            CustodyLog log = new CustodyLog
            {
                EvidenceId = evidenceId,
                HandledByUserId = loggedInUser.UserId,
                Timestamp = DateTime.Now,
                Notes = txtNotes.Text
            };

            log.LogChainOfCustody();

            MessageBox.Show("Custody log entry added.");
            txtNotes.Clear();
            LoadCustodyLog();
        }
    }
}