using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            string userName = CleanInput(txtAddName.Text);
            if (!string.IsNullOrWhiteSpace(userName))
            {
                if (crapsDataSet.User.Select("Name = '" + userName + "'").Length != 0)
                {
                    MessageBox.Show("That player already exists. Please enter a new player or select your name from the list.");
                }
                else
                {
                    CrapsDataSet.UserRow userRow = crapsDataSet.User.NewUserRow();
                    userRow.Name = userName.ToUpper();
                    crapsDataSet.User.Rows.Add(userRow);
                    try
                    {
                        userTableAdapter.Insert(userName);
                    }
                    catch
                    {
                        MessageBox.Show("Insert Failed");
                    }
                    userTableAdapter.Fill(crapsDataSet.User);
                    PlayerActivate(userName);
                }
            }
            else
            {
                MessageBox.Show("Your name cannot be empty.");
            }

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
            PlayerActivate(lsboxChooseName.GetItemText(lsboxChooseName.SelectedItem));
        }

        private void PlayerActivate(string userName)
        {
            GameVariables.UserID = (int)crapsDataSet.User.Select("Name = '" + userName + "'")[0]["Id"];
            rollHistBindingSource.Filter = "[Player ID] = " + GameVariables.UserID;
            rollHistTableAdapter.Fill(crapsDataSet.RollHist);
            txtAddName.Text = "";
            gbWelcomeScreen.Enabled = false;
            gbPlayMenu.Visible = true;
            gbPlayerMenu.Visible = true;
            gbPlayMenu.Enabled = true;
            gbPlayerMenu.Enabled = true;
            NewGame();
        }

        private void NewGame()
        {
            CrapsDataSet.GameRow gameRow = crapsDataSet.Game.NewGameRow();
            gameRow["Player Id"] = GameVariables.UserID;
            crapsDataSet.Game.AddGameRow(gameRow);
            try
            {
                gameTableAdapter.Update(crapsDataSet.Game);
            }
            catch
            {
                MessageBox.Show("Insert Failed");
            }
            GameVariables.Round = 1;
            lblWinValue.Text = String.Join(" or ", GameVariables.Wins);
            lblLossValue.Text = String.Join(" or ", GameVariables.Loses);
            GameVariables.PointWin = 0;
            rollHistTableAdapter.Fill(crapsDataSet.RollHist);
            gameTableAdapter.Fill(crapsDataSet.Game);
        }

        private void PlayerDeactivate()
        {
            GameVariables.UserID = 0;
            crapsDataSet.RollHist.Clear();
            gbWelcomeScreen.Enabled = true;
            gbPlayMenu.Enabled = false;
            gbPlayerMenu.Enabled = false;
        }

        private void BtnChangePlayer_Click(object sender, EventArgs e)
        {
            PlayerDeactivate();
        }

        private void BtnUpdateName_Click(object sender, EventArgs e)
        {
            FormUpdateName formUpdateName = new FormUpdateName();
            formUpdateName.FormClosed += new FormClosedEventHandler(UpdateForm_Closed);
            formUpdateName.Show();

        }

        private void UpdateForm_Closed(object sender, FormClosedEventArgs e)
        {
            userTableAdapter.Fill(crapsDataSet.User);
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            FormConfirm formConfirm = new FormConfirm("Clear player history?");
            if (formConfirm.ShowDialog() == DialogResult.OK)
            {
                ClearPlayerHistory();
                NewGame();
            }
        }

        private void ClearPlayerHistory()
        {
            ClearPlayerRolls();
            ClearPlayerGames();
        }

        private void ClearPlayerGames()
        {
            for (int i = crapsDataSet.Game.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dataRow = crapsDataSet.Game.Rows[i];
                if (dataRow.Field<int>("Player ID") == GameVariables.UserID)
                {
                    dataRow.Delete();
                }
            }
            gameTableAdapter.Update(crapsDataSet.Game);
            gameTableAdapter.Fill(crapsDataSet.Game);
        }

        private void ClearPlayerRolls()
        {
            for (int i = crapsDataSet.Roll.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dataRow = crapsDataSet.Roll.Rows[i];
                if (dataRow.Field<int>("PlayerID") == GameVariables.UserID)
                {
                    dataRow.Delete();
                }
            }
            rollTableAdapter.Update(crapsDataSet.Roll);
            rollTableAdapter.Fill(crapsDataSet.Roll);
            rollHistTableAdapter.Fill(crapsDataSet.RollHist);
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            FormConfirm formConfirm = new FormConfirm("Clear player history and delete player?");
            if (formConfirm.ShowDialog() == DialogResult.OK)
            {
                ClearPlayerHistory();
                DeletePlayer();
                PlayerDeactivate();
            }
        }

        private void DeletePlayer()
        {
            CrapsDataSet.UserRow userRow = crapsDataSet.User.FindById(GameVariables.UserID);
            ClearPlayerHistory();
            userRow.Delete();
            userTableAdapter.Update(crapsDataSet.User);
            userTableAdapter.Fill(crapsDataSet.User);
            rollHistTableAdapter.Fill(crapsDataSet.RollHist);
        }

        private async void BtnRollDice_Click(object sender, EventArgs e)
        {
            int[] rolls = await RollDice();
            lblOutcome.Visible = true;
            PopulateRolls(rolls);
            if (GameOver() == 0)
            {
                lblOutcome.Text = "You Lost :(";
                ResetGame("Loss");
            }
            else if (GameOver() == 1)
            {
                lblOutcome.Text = "You Win!";
                GameVariables.Round = 1;
                ResetGame("Win");
            }
            else
            {
                if (GameVariables.Round == 1)
                {
                    SetPoint();
                    lblOutcome.Text = "Roll again!";
                }
                GameVariables.Round++;
            }
        }

        private void ResetGame(string winorlose)
        {
            int currentGame = (crapsDataSet.Game.Select("[Player ID] = " + GameVariables.UserID, "Id DESC").Count() > 0) ? (int)crapsDataSet.Game.Select("[Player ID] = " + GameVariables.UserID, "Id DESC")[0]["Id"] : 0;
            CrapsDataSet.GameRow gameRow = crapsDataSet.Game.FindById(currentGame);
            gameRow["Result"] = winorlose;
            gameRow["Time"] = DateTime.Now;
            if (GameVariables.PointWin > 0)
            {
                gameRow["Point"] = GameVariables.PointWin.ToString();
            }
            gameTableAdapter.Update(crapsDataSet.Game);
            try
            {
                gameTableAdapter.Update(crapsDataSet.Game);
            }
            catch
            {
                MessageBox.Show(currentGame.ToString());
            }
            gameTableAdapter.Fill(crapsDataSet.Game);
            NewGame();
        }

        private void SetPoint()
        {
            GameVariables.PointWin = Convert.ToInt32(lblDieTotalValue.Text);
            lblWinValue.Text = GameVariables.PointWin.ToString();
            lblLossValue.Text = GameVariables.PointLose.ToString();
        }

        private int GameOver()
        {
            int score = Convert.ToInt32(lblDieTotalValue.Text);
            if (GameVariables.Round == 1)
            {
                if (GameVariables.Wins.Contains(score))
                {
                    return 1;
                }
                else if (GameVariables.Loses.Contains(score))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (score == GameVariables.PointWin)
                {
                    return 1;
                }
                else if (score == GameVariables.PointLose)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

        private void PopulateRolls(int[] rolls)
        {
            lblDie1Value.Text = rolls[0].ToString();
            lblDie2Value.Text = rolls[1].ToString();
            lblDieTotalValue.Text = (rolls[0] + rolls[1]).ToString();
            ShowDice();

            int currentGame = (crapsDataSet.Game.Select("[Player ID] = " + GameVariables.UserID, "Id DESC").Count() > 0) ? (int)crapsDataSet.Game.Select("[Player ID] = " + GameVariables.UserID, "Id DESC")[0]["Id"] : 0; // this breaks if you delete history i nthe middle of a game
            CrapsDataSet.RollRow rollRow = crapsDataSet.Roll.NewRollRow();
            rollRow["PlayerID"] = GameVariables.UserID;
            rollRow["Game"] = currentGame;
            rollRow["Die1"] = rolls[0];
            rollRow["Die2"] = rolls[1];
            rollRow["RollNum"] = GameVariables.Round;
            if (GameVariables.PointWin != 0)
            {
                rollRow["Point"] = GameVariables.PointWin.ToString();
            }

            crapsDataSet.Roll.AddRollRow(rollRow);
            try
            {
                rollTableAdapter.Update(crapsDataSet.Roll);
            }
            catch
            {
                MessageBox.Show("Insert Failed");
            }
            rollTableAdapter.Fill(crapsDataSet.Roll);
            rollHistTableAdapter.Fill(crapsDataSet.RollHist);
        }

        private void ShowDice()
        {
            lblDie1Value.Visible = true;
            lblDie2Value.Visible = true;
            lblDieTotalValue.Visible = true;
            lblRollDie1.Visible = true;
            lblRollDie2.Visible = true;
            lblRollTotal.Visible = true;
        }

        private async Task<int[]> RollDice()
        {


            Dice dice = await GetDiceAsync("https://rolz.org/api/?2d6.json");
            if (dice != null)
            {
                int[] diceValues = new int[2];
                diceValues[0] = Convert.ToInt32(Regex.Match(dice.details, @"(?<=\()\d").ToString());
                diceValues[1] = Convert.ToInt32(Regex.Match(dice.details, @"(?<=\+)\d").ToString());
                return diceValues;
            }
            else
            {
                MessageBox.Show("Connection Failed. Generating Rolls Locally");
                Random rnd = new Random();
                return new int[] { rnd.Next(1, 7), rnd.Next(1, 7) };
            }
        }

        internal static string CleanInput(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters, 
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        internal static async Task<Dice> GetDiceAsync(string path)
        {
            try
            {
                Dice dice = null;
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    dice = await response.Content.ReadAsAsync<Dice>();
                }
                return dice;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
    }
}
