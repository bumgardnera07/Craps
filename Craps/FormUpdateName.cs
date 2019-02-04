using System;
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
            userTableAdapter.Fill(crapsDataSet.User);
            TextUpdateName.Text = crapsDataSet.User.Select("Id = " + GameVariables.UserID)[0]["Name"].ToString();
        }

        private void TextUpdateName_KeyDown(object sender, KeyEventArgs e)  //lets you press enter in the text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAcceptNameUpdate.PerformClick();
            }
        }

        private void BtnAcceptNameUpdate_Click(object sender, EventArgs e)
        {
            Close();          
        }

        private void BtnCancelUpdateName_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUpdateName_Shown(object sender, EventArgs e)
        {
            TextUpdateName.Focus();
            TextUpdateName.Select(0, 0);
        }
    }
}
