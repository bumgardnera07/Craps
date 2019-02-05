using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public class DiceController
    {   // Following properties for rolz API .json format
        public string input{ get; set; }
        public string result { get; set; }
        public string details { get; set; }
        public string code { get; set; }
        public string illustration { get; set; }
        public string timestamp { get; set; }
        public string x { get; set; }



        public static void PopulateRolls(int[] rolls, FormMainPage form)
        {
            form.lblOutcome.Visible = true;
            form.lblDie1Value.Text = rolls[0].ToString();
            form.lblDie2Value.Text = rolls[1].ToString();
            form.lblDieTotalValue.Text = (rolls[0] + rolls[1]).ToString();
            ShowDice(form);

            int currentGame = (form.crapsDataSet.Game.Select("[Player ID] = " + GameVariables.UserID).Count() > 0) 
                                ? (int)form.crapsDataSet.Game.Select("[Player ID] = " + GameVariables.UserID, "Id DESC")[0]["Id"] 
                                : 0;
            CrapsDataSet.RollRow rollRow = form.crapsDataSet.Roll.NewRollRow();
            rollRow["PlayerID"] = GameVariables.UserID;
            rollRow["Game"] = currentGame;
            rollRow["Die1"] = rolls[0];
            rollRow["Die2"] = rolls[1];
            rollRow["RollNum"] = GameVariables.Round;

            if (GameVariables.PointWin != 0)
            {
                rollRow["Point"] = GameVariables.PointWin.ToString();
            }

            form.crapsDataSet.Roll.AddRollRow(rollRow);
            try
            {
                form.rollTableAdapter.Update(form.crapsDataSet.Roll);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            form.rollTableAdapter.Fill(form.crapsDataSet.Roll);
            form.rollHistTableAdapter.Fill(form.crapsDataSet.RollHist);
        }

        private static void ShowDice(FormMainPage form)
        {
            form.lblDie1Value.Visible = true;
            form.lblDie2Value.Visible = true;
            form.lblDieTotalValue.Visible = true;
            form.lblRollDie1.Visible = true;
            form.lblRollDie2.Visible = true;
            form.lblRollTotal.Visible = true;
        }

        internal static async Task<int[]> RollDice(FormMainPage form, HttpClient client)
        {
            DiceController dice = await GetDiceAsync("https://rolz.org/api/?2d6.json", form, client);
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

        private static async Task<DiceController> GetDiceAsync(string path, FormMainPage form, HttpClient httpClient)
        {
            try
            {
                DiceController dice = null;
                HttpResponseMessage response = await httpClient.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    dice = await response.Content.ReadAsAsync<DiceController>();
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
