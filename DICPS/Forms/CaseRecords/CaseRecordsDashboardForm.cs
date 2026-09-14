using DICPS.Forms.CaseRecords;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICPS.Forms.CaseRecords
{
    public partial class CaseRecordsDashboardForm : Form
    {
        public CaseRecordsDashboardForm()
        {
            InitializeComponent();
        }

        private void lblColdCase_Click(object sender, EventArgs e)
        {

        }

        private void lblCaseSearch_Click(object sender, EventArgs e)


        {

        }
        

        private void lblDICPS_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCase_Click(object sender, EventArgs e)
        
           
        {
            CaseFileForm caseFileForm = new CaseFileForm();
            caseFileForm.FormClosed += (s, args) => this.Show();
            caseFileForm.Show();
            this.Hide();
        }
        

        private void btnColdCase_Click(object sender, EventArgs e)
        {
    
        ColdCaseForm coldCaseForm = new ColdCaseForm();
        coldCaseForm.FormClosed += (s, args) => this.Show();
        coldCaseForm.Show();
        this.Hide();
    
}

        private void btnCaseSearch_Click(object sender, EventArgs e)
        {
            CaseSearchForm caseSearchForm = new CaseSearchForm();
            caseSearchForm.FormClosed += (s, args) => this.Show();
            caseSearchForm.Show();
            this.Hide();
        }

        private void lblcrd_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

        }
    }
}
