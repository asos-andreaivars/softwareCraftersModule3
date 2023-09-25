namespace TicTacToeGame
{
    public class GameController
    {
        private int _turn;
        private Board _board;

        public GameController()
        {
            _board = new Board();
            _turn = 0;
        }

        public void StartGame()
        {
            _board = new Board();
            _turn = 0;
        }

        public char CurrentPlayer()
        {
            if (_turn % 2 == 0)
            {
                return 'X';
            }
            return 'O';
        }

        public void MakeMove(int position)
        {
            var hasAddedToBoard = _board.AddToBoard(position, CurrentPlayer());
            if (hasAddedToBoard)
            {
                _turn++;
            }
        }
    }
}