using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Craps
{
    public class PlayerController
    {

        public static void ClearPlayerHistory(FormMainPage form)
        {
            ClearPlayerRolls(form);
            ClearPlayerGames(form);
        }

        private static void ClearPlayerGames(FormMainPage form)
        {
            for (int i = form.crapsDataSet.Game.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dataRow = form.crapsDataSet.Game.Rows[i];
                if (dataRow.Field<int>("Player ID") == GameVariables.UserID)
                {
                    dataRow.Delete();
                }
            }
            form.gameTableAdapter.Update(form.crapsDataSet.Game);
            form.gameTableAdapter.Fill(form.crapsDataSet.Game);
        }

        private static void ClearPlayerRolls(FormMainPage form)
        {
            for (int i = form.crapsDataSet.Roll.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dataRow = form.crapsDataSet.Roll.Rows[i];
                if (dataRow.Field<int>("PlayerID") == GameVariables.UserID)
                {
                    dataRow.Delete();
                }
            }
            form.rollTableAdapter.Update(form.crapsDataSet.Roll);
            form.rollTableAdapter.Fill(form.crapsDataSet.Roll);
            form.rollHistTableAdapter.Fill(form.crapsDataSet.RollHist);
        }

        public static void DeletePlayer(FormMainPage form)
        {
            CrapsDataSet.UserRow userRow = form.crapsDataSet.User.FindById(GameVariables.UserID);
            ClearPlayerHistory(form);
            userRow.Delete();
            form.userTableAdapter.Update(form.crapsDataSet.User);
            form.userTableAdapter.Fill(form.crapsDataSet.User);
            form.rollHistTableAdapter.Fill(form.crapsDataSet.RollHist);
        }

        private static string CleanUserName(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\.-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If timeout when replacing invalid characters, return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }


        public static void AddAndActivatePlayer(string inputName, FormMainPage form)
        {
            string userName = CleanUserName(inputName);
            if (!string.IsNullOrWhiteSpace(userName))
            {
                if (form.crapsDataSet.User.Select("Name = '" + userName + "'").Length != 0)
                {
                    MessageBox.Show("That player already exists. Please enter a new player or select your name from the list.");
                }
                else
                {
                    CrapsDataSet.UserRow userRow = form.crapsDataSet.User.NewUserRow();
                    userRow.Name = userName.ToUpper();
                    form.crapsDataSet.User.Rows.Add(userRow);
                    try
                    {
                        form.userTableAdapter.Insert(userName.ToUpper());
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);  
                    }
                    form.userTableAdapter.Fill(form.crapsDataSet.User);
                    ViewController.PlayerActivate(userName, form);
                }
            }
            else
            {
                MessageBox.Show("Your name cannot be empty.");
            }
        }

        public static void UpdateUser(string inputName, FormMainPage form)
        {
            string userName = CleanUserName(inputName);
            if (form.crapsDataSet.User.Select("Name = '" + userName + "'").Length != 0)
            {
                MessageBox.Show("That player already exists.");
            }
            else
            {
                CrapsDataSet.UserRow userRow = form.crapsDataSet.User.FindById(GameVariables.UserID);
                userRow.Name = userName.ToUpper();
                try
                {
                    form.userTableAdapter.Update(form.crapsDataSet);
                    form.userTableAdapter.Fill(form.crapsDataSet.User);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message); 
                }

            }
        }
    }
}
