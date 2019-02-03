using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class FormConfirm : Form
    {
        public FormConfirm(string ConfirmText = "Confirm?")
        {
            InitializeComponent();
            LblConfirm.Text = ConfirmText;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
