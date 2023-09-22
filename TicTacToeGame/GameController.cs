namespace TicTacToeGame
{
    public class GameController
    {
        private int _turn;
        public GameController()
        {
            _turn = 0;
        }

        public void StartGame()
        {
            
        }

        public string CurrentPlayer()
        {
            if(_turn == 0)
            {
                return "X";
            }
            return "O";
        }

        public void MakeMove(int x, int y)
        {
            _turn++;
        }
    }
}