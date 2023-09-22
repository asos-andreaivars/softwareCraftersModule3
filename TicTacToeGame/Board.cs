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
            string visualBoard = "";
            for (int i = 0; i < _board.Length; i++)
            {
                visualBoard += $" {_board[i]} " ;
                if ((i+1) % 3 ==0)
                {
                    visualBoard += "\n";
                }
                else
                {
                    visualBoard += "|";
                }
            }
            return visualBoard.Substring(0, visualBoard.Length - 1);
        }

        public void AddToBoard(int position, char player)
        {
            _board[position] = player;
        }
    }
}