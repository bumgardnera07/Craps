namespace Craps
{
    class ViewController
    {
        internal static void PlayerActivate(string userName, FormMainPage form)
        {
            GameVariables.UserID = (int)form.crapsDataSet.User.Select("Name = '" + userName + "'")[0]["Id"];
            form.rollHistBindingSource.Filter = "[Player ID] = " + GameVariables.UserID;
            form.rollHistTableAdapter.Fill(form.crapsDataSet.RollHist);
            form.txtAddName.Text = "";
            form.gbWelcomeScreen.Enabled = false;
            form.gbPlayMenu.Visible = true;
            form.gbPlayerMenu.Visible = true;
            form.gbPlayMenu.Enabled = true;
            form.gbPlayerMenu.Enabled = true;
            GameController.NewGame(form);
        }

        internal static void PlayerDeactivate(FormMainPage form)
        {
            GameVariables.UserID = 0;
            form.crapsDataSet.RollHist.Clear();
            form.gbWelcomeScreen.Enabled = true;
            form.gbPlayMenu.Enabled = false;
            form.gbPlayerMenu.Enabled = false;
        }
    }
}
