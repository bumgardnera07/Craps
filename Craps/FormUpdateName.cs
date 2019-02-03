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
    public partial class FormUpdateName : Form
    {
        public FormUpdateName()
        {
            InitializeComponent();
        }

        private void FormUpdateName_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.crapsDataSet.User);
            TextUpdateName.Text = crapsDataSet.User.Select("Id = " + GameVariables.UserID)[0]["Name"].ToString();
        }

        private void TextUpdateName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAcceptNameUpdate.PerformClick();
            }
        }

        private void BtnAcceptNameUpdate_Click(object sender, EventArgs e)
        {
            string userName = TextUpdateName.Text;
            if (crapsDataSet.User.Select("Name = '" + userName + "'").Length != 0)
            {
                MessageBox.Show("That player already exists.");
            }
            else
            {
                CrapsDataSet.UserRow userRow = crapsDataSet.User.FindById(GameVariables.UserID);
                userRow.Name = TextUpdateName.Text;
                try
                {
                    userTableAdapter.Update(crapsDataSet);
                }
                catch
                {
                    MessageBox.Show("Insert Failed");
                }
                this.userTableAdapter.Fill(this.crapsDataSet.User);
                this.Close();
            }
        }

        private void BtnCancelUpdateName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdateName_Shown(object sender, EventArgs e)
        {
            TextUpdateName.Focus();
            TextUpdateName.Select(0, 0);
        }
    }
}
