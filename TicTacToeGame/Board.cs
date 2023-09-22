namespace TicTacToeGame
{
    public class Board
    {
        private char[] _board;

        public Board()
        {
            _board = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };

        }

        public string GetVisualBoard()
        {
            return "   |   |   \n   |   |   \n   |   |   ";
        }

        public void AddToBoard(int position, string player)
        {


        }

    }
}