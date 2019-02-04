namespace Craps
{
    internal static class GameVariables
    {
        private static readonly int[] _wins = new int[2] { 7, 11 };
        private static readonly int[] _loses = new int[3] { 2, 3, 12 };
        private static int _userID;
        private static int _pointWin = 0;
        private static int _pointLose = 7;
        private static int _round = 1;

        public static int UserID { get => _userID; set { _userID = value;} }
        public static int PointWin { get => _pointWin; set => _pointWin = value; }
        public static int PointLose { get => _pointLose; set => _pointLose = value; }
        public static int Round { get => _round; set => _round = value; }
        public static int[] Wins => _wins;
        public static int[] Loses => _loses;
    }
}
