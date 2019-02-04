using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Craps
{
    public partial class FormMainPage : Form
    {
        internal static HttpClient client = new HttpClient();
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void CrapsForm_Load(object sender, EventArgs e)
        {
            rollTableAdapter.Fill(crapsDataSet.Roll);
            userTableAdapter.Fill(crapsDataSet.User);
            gameTableAdapter.Fill(crapsDataSet.Game);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            PlayerController.AddAndActivateUser(txtAddName.Text, this);
        }

        private void TxtAddName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddUser.PerformClick();
            }
        }

        private void LsboxChooseName_DoubleClick(object sender, EventArgs e)
        {
            ViewController.PlayerActivate(lsboxChooseName.GetItemText(lsboxChooseName.SelectedItem), this);
        }

        private void BtnChangePlayer_Click(object sender, EventArgs e)
        {
            ViewController.PlayerDeactivate(this);
        }

        private void BtnUpdateName_Click(object sender, EventArgs e)
        {
            FormUpdateName formUpdateName = new FormUpdateName();
            if (formUpdateName.ShowDialog(this) == DialogResult.OK)
            {
                PlayerController.UpdateUser(formUpdateName.TextUpdateName.Text, this);
            }
            else
            {
                formUpdateName.Dispose();
            }

        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            FormConfirm formConfirm = new FormConfirm("Clear player history?");
            if (formConfirm.ShowDialog() == DialogResult.OK)
            {
                PlayerController.ClearPlayerHistory(this);
                GameController.NewGame(this);
            }
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            FormConfirm formConfirm = new FormConfirm("Clear player history and delete player?");
            if (formConfirm.ShowDialog() == DialogResult.OK)
            {
                PlayerController.ClearPlayerHistory(this);
                PlayerController.DeletePlayer(this);
                ViewController.PlayerDeactivate(this);
            }
        }

        private async void BtnRollDice_Click(object sender, EventArgs e)
        {
            int[] rolls = await DiceController.RollDice(this, client);
            DiceController.PopulateRolls(rolls, this, client);
            GameController.UpdateGameState(this);
        }
    }
}
