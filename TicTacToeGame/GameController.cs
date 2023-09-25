namespace TicTacToeGame
{
    public class GameController
    {
        private int _turn;
        private Board _board;
        public bool IsComplete { get; private set; }
        public bool HasWinner { get; private set; }

        public GameController()
        {
            _board = new Board();
            _turn = 0;
            IsComplete = false;
            HasWinner = false;
        }

        public void StartGame()
        {
            _board = new Board();
            _turn = 0;
            IsComplete = false;
            HasWinner = false;
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
                if(_turn == 8)
                {
                    IsComplete = true;
                }
                _turn++;
            }
        }
    }
}