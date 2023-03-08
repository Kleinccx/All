using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumSquence
{
    public partial class frmSequence : Form
    {
        public frmSequence()
        {
            InitializeComponent();
        }

        private void IsNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkCombo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCombo.Checked)
                cmbNum.Visible = true;
            else
                cmbNum.Visible = false;
        }

        private void frmSequence_Load(object sender, EventArgs e)
        {
            cmbNum.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                cmbNum.Items.Add(i.ToString());
            }
        }

        private void chkList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkList.Checked)
                IsNum.Visible = true;
            else
                IsNum.Visible = false;
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
            IsNum.Items.Clear();
            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)
              IsNum.Items.Add(((int)i).ToString());
            
        }

        private void rbEven_CheckedChanged(object sender, EventArgs e)
        {
            IsNum.Items.Clear();
            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)

                if (i % 2== 0)
                IsNum.Items.Add(((int)i).ToString());

            cmbNum.Items.Clear();
            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)

                if (i % 2 == 0)
                    cmbNum.Items.Add(((int)i).ToString());
        }

        private void rbOdd_CheckedChanged(object sender, EventArgs e)
        {
            IsNum.Items.Clear();
            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)

                if (i % 2 == 1)
                    IsNum.Items.Add(((int)i).ToString());

            cmbNum.Items.Clear();
            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)

                if (i % 2 == 1)
                    cmbNum.Items.Add(((int)i).ToString());
        }

        private void rbDiv_CheckedChanged(object sender, EventArgs e)
        {
            IsNum.Items.Clear();
            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)

                if (i % 5 == 0)
                    IsNum.Items.Add(((int)i).ToString());

            cmbNum.Items.Clear();
            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)

                if (i % 5 == 0)
                    cmbNum.Items.Add(((int)i).ToString());
        }

        private void cmbNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
