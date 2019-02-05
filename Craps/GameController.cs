using System;
using System.Linq;
using System.Windows.Forms;

namespace Craps
{
    public class GameController
    {
        public static void NewGame(FormMainPage form)
        {
            CrapsDataSet.GameRow gameRow = form.crapsDataSet.Game.NewGameRow();
            gameRow["Player Id"] = GameVariables.UserID;
            form.crapsDataSet.Game.AddGameRow(gameRow);
            try
            {
                form.gameTableAdapter.Update(form.crapsDataSet.Game);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            GameVariables.Round = 1;
            form.lblWinValue.Text = string.Join(" or ", GameVariables.Wins);
            form.lblLossValue.Text = string.Join(" or ", GameVariables.Loses);
            GameVariables.PointWin = 0;
            form.rollHistTableAdapter.Fill(form.crapsDataSet.RollHist);
            form.gameTableAdapter.Fill(form.crapsDataSet.Game);
        }

        public static void UpdateGameState(FormMainPage form)
        {
            if (GameOver(form) == 0)
            {
                form.lblOutcome.Text = "You Lost :(";
                ResetGame("Loss", form);
            }
            else if (GameOver(form) == 1)
            {
                form.lblOutcome.Text = "You Win!";
                ResetGame("Win", form);
            }
            else
            {
                if (GameVariables.Round == 1)
                {
                    SetPoint(form);
                    form.lblOutcome.Text = "Roll again!";
                }
                GameVariables.Round++;
            }
        }


        private static void ResetGame(string winorlose, FormMainPage form)
        {
            int currentGame = (form.crapsDataSet.Game.Select("[Player ID] = " + GameVariables.UserID, "Id DESC").Count() > 0) 
                                ? (int)form.crapsDataSet.Game.Select("[Player ID] = " + GameVariables.UserID, "Id DESC")[0]["Id"] 
                                : 0;
            CrapsDataSet.GameRow gameRow = form.crapsDataSet.Game.FindById(currentGame);
            gameRow["Result"] = winorlose;
            gameRow["Time"] = DateTime.Now;
            if (GameVariables.PointWin > 0)
            {
                gameRow["Point"] = GameVariables.PointWin.ToString();
            }
            form.gameTableAdapter.Update(form.crapsDataSet.Game);
            try
            {
                form.gameTableAdapter.Update(form.crapsDataSet.Game);
            }
            catch
            {
                MessageBox.Show(currentGame.ToString());
            }
            form.gameTableAdapter.Fill(form.crapsDataSet.Game);
            GameController.NewGame(form);
        }

        private static void SetPoint(FormMainPage form)
        {
            GameVariables.PointWin = Convert.ToInt32(form.lblDieTotalValue.Text);
            form.lblWinValue.Text = GameVariables.PointWin.ToString();
            form.lblLossValue.Text = GameVariables.PointLose.ToString();
        }

        private static int GameOver(FormMainPage form)
        {
            int score = Convert.ToInt32(form.lblDieTotalValue.Text);
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
    }
}