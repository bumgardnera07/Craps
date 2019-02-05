using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Craps.Tests
{

    [TestClass()]

    public class PlayerControllerTests
    {
        private static FormMainPage testMain = new FormMainPage();

        [TestMethod()]
        public void NewPlayerAddsaRowtoDBTest()
        {
            //Arrange
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            int beforeAddPlayer = testMain.crapsDataSet.User.Rows.Count;

            //Act
            PlayerController.AddAndActivatePlayer("UserTEst", testMain);

            //Assert
            int afterAddPlayer = testMain.crapsDataSet.User.Rows.Count;
            Assert.AreEqual(beforeAddPlayer + 1, afterAddPlayer);
        }

        [TestMethod()]
        public void ClearPlayerHistoryEmptiesPlayerRolls()
        {
            //Arrange
            GameVariables.Round = 1;
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            PlayerController.AddAndActivatePlayer("RollTest", testMain);
            GameController.NewGame(testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);

            //Act
            PlayerController.ClearPlayerHistory(testMain);

            //Assert
            int afterClearRolls = testMain.crapsDataSet.Roll.Rows.Count;
            Assert.AreEqual(0, afterClearRolls);
        }

        [TestMethod()]
        public void ClearPlayerHistoryEmptiesPlayerGames()
        {
            //Arrange
            GameVariables.Round = 1;
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            PlayerController.AddAndActivatePlayer("RollTest", testMain);
            GameController.NewGame(testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);

            //Act
            PlayerController.ClearPlayerHistory(testMain);

            //Assert
            int afterClearGames = testMain.crapsDataSet.Game.Rows.Count;
            Assert.AreEqual(1, afterClearGames); //this should equal 1 because Clearing History starts a new game automatically
        }

        [TestMethod()]
        public void DeletePlayerEmptiesRemovesPlayerfromDB()
        {
            //Arrange
            GameVariables.Round = 1;
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            PlayerController.AddAndActivatePlayer("DeleteTest", testMain);
            GameController.NewGame(testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);

            //Act
            PlayerController.DeletePlayer(testMain);

            //Assert
            Assert.AreEqual(0, testMain.crapsDataSet.User.Select("Name = '" + "DeleteTest" + "'").Length); 
        }

        [TestMethod()]
        public void AddAndActivatePlayerAddsPlayerToDB()
        {
            //Arrange
            GameVariables.Round = 1;
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            int beforeAdd = testMain.crapsDataSet.User.Rows.Count;

            //Act
            PlayerController.AddAndActivatePlayer("AddPlayerTest", testMain);

            //Assert
            Assert.AreNotEqual(0, testMain.crapsDataSet.User.Select("Name = '" + "AddPlayerTest" + "'").Length);
        }

        [TestMethod()]
        public void UpdatePlayerChangesPlayerName()
        {
            //Arrange
            GameVariables.Round = 1;
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            int beforeAdd = testMain.crapsDataSet.User.Rows.Count;
            PlayerController.AddAndActivatePlayer("UpdatePlayerTest", testMain);

            //Act
            PlayerController.UpdateUser("UpdatedName", testMain);

            //Assert
            Assert.AreNotEqual(0, testMain.crapsDataSet.User.Select("Name = '" + "UpdatedName" + "'").Length);
            Assert.AreEqual(0, testMain.crapsDataSet.User.Select("Name = '" + "UpdatePlayerTest" + "'").Length);
        }


        [ClassCleanup]

        public static void TearDown()
        {
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
        }
    }

    [TestClass()]

    public class GameControllerTests
    {
        private static FormMainPage testMain = new FormMainPage();

        [TestMethod()]
        public void NewGameAddsaRowtoDBTest()
        {
            //Arrange
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            PlayerController.AddAndActivatePlayer("GameTest", testMain);
            int beforeNewGame = (testMain.crapsDataSet.Game.Rows.Count);

            //Act
            GameController.NewGame(testMain);

            //Assert
            int afterNewGame = (testMain.crapsDataSet.Game.Rows.Count);
            Assert.AreEqual(beforeNewGame + 1, afterNewGame);
        }

        [TestMethod()]
        public void UpdateGameStateIncrementsRoundNumber()
        {
            //Arrange
            testMain.crapsDataSet.Clear();            
            int beforeUpdate = (GameVariables.Round);

            //Act
            GameController.UpdateGameState(testMain);

            //Assert
            int afterUpdate = (GameVariables.Round);
            Assert.AreEqual(beforeUpdate + 1, afterUpdate);
        }

        [TestMethod()]
        public void UpdateGameStateResetsRoundNumberonWin()
        {
            //Arrange
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            GameController.NewGame(testMain);
            testMain.lblDieTotalValue.Text = 8.ToString();
            GameVariables.PointWin = 8;
            GameVariables.Round = 2;

            //Act
            GameController.UpdateGameState(testMain);

            //Assert
            int afterUpdate = (GameVariables.Round);
            Assert.AreEqual(afterUpdate, 1);
        }

        [TestMethod()]
        public void UpdateGameStateDisplaysYouWinonWinningRollsTest()
        {
            //Arrange
            testMain.crapsDataSet.Clear();
            testMain.lblDieTotalValue.Text = 7.ToString();
            GameController.NewGame(testMain);
            GameVariables.Round = 1;

            //Act

            GameController.UpdateGameState(testMain);

            //Assert
            Assert.AreEqual(testMain.lblOutcome.Text, "You Win!");
        }

        [TestMethod()]
        public void UpdateGameStateDisplaysYouLoseonLosingRollsTest()
        {
            //Arrange
            testMain.crapsDataSet.Clear();
            testMain.lblDieTotalValue.Text = 2.ToString();
            GameController.NewGame(testMain);
            GameVariables.Round = 1;

            //Act

            GameController.UpdateGameState(testMain);

            //Assert
            Assert.AreEqual(testMain.lblOutcome.Text, "You Lost :(");
        }

        [ClassCleanup]

        public static void TearDown()
        {
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
        }
    }

    [TestClass()]

    public class DiceControllerTests
    {
        public static FormMainPage testMain = new FormMainPage();

        [TestMethod()]
        public void PopulateRollsAddsRollRowtoDBTest()
        {
            //Arrange

            GameVariables.Round = 1;
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
            PlayerController.AddAndActivatePlayer("RollTest", testMain);
            GameController.NewGame(testMain);
            int beforePopRolls = (testMain.crapsDataSet.Roll.Rows.Count);

            //Act
            DiceController.PopulateRolls(new int[2] { 1, 1 }, testMain);

            //Assert
            int afterPopRolls = (testMain.crapsDataSet.Roll.Rows.Count);
            Assert.AreEqual(beforePopRolls + 1, afterPopRolls);
        }

        [ClassCleanup]

        public static void TearDown()
        {
            testMain.crapsDataSet.Clear();
            testMain.tableAdapterManager.UpdateAll(testMain.crapsDataSet);
        }

    }

}