namespace TicTacToeGame
{
    public class Board
    {
        private readonly char[] _board;

        public Board()
        {
            _board = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
        }

        public string GetVisualBoard()
        {
            string visualBoard = "";
            for (int i = 0; i < _board.Length; i++)
            {
                visualBoard += $" {_board[i]} ";
                if ((i + 1) % 3 == 0)
                {
                    visualBoard += "\n";
                }
                else
                {
                    visualBoard += "|";
                }
            }
            return visualBoard[..^1];
        }

        public bool AddToBoard(int position, char player)
        {
            if (_board[position].Equals(' '))
            {
                _board[position] = player;
                return true;
            }
            return false;
        }
    }
}