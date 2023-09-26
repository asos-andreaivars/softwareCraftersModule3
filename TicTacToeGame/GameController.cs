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
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(_board.GetVisualBoard());
                Console.WriteLine($"Please make your move player {CurrentPlayer()}");
                var position = ReadIntKey();
                Console.WriteLine();
                MakeMove(position);

                if (IsComplete)
                {
                    Console.WriteLine("Would you like to play another game? (y/n)");
                    if (ReadYNKey())
                    {
                        RestartGame();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static int ReadIntKey()
        {
            var key = -1;
            ConsoleKeyInfo UserInput = Console.ReadKey();
            if (char.IsDigit(UserInput.KeyChar))
                key = int.Parse(UserInput.KeyChar.ToString());

            return key;
        }

        public static bool ReadYNKey()
        {
            ConsoleKeyInfo UserInput = Console.ReadKey();
            if (UserInput.KeyChar == 'y' || UserInput.KeyChar == 'n')
                return UserInput.KeyChar == 'y';

            Console.WriteLine("Please enter y or n");
            return ReadYNKey();
        }

        public void RestartGame()
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
                CheckWin();
                if (_turn == 8)
                {
                    IsComplete = true;
                }
                _turn++;
            }
            else
            {
                Console.WriteLine($"That is not a valid move, please make your move again player {CurrentPlayer()}");
            }
        }

        public void CheckWin()
        {
            var winCondition = new List<int[]> {
                new int[] {0, 1, 2},
                new int[] {3, 4, 5},
                new int[] {6, 7, 8},
                new int[] {0, 3, 6},
                new int[] {1, 4, 7},
                new int[] {2, 5, 8},
                new int[] {0, 4, 8},
                new int[] {2, 4, 6} };
            var currentPlayerBoard = _board.GetPlayerPositionsOnBoard(CurrentPlayer());

            foreach (var winner in winCondition)
            {
                bool isSubset = !winner.Except(currentPlayerBoard).Any();
                if (isSubset)
                {
                    HasWinner = true;
                    IsComplete = true;
                    Console.WriteLine($"Player {CurrentPlayer()} is the winner!");
                    return;
                }
            }
        }
    }
}