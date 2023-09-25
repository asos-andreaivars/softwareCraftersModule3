using NUnit.Framework;
using TicTacToeGame;

namespace TicTacToe.UnitTests
{
    public class GameControllerShould
    {

        [TestCase("X", new int[] { })]
        [TestCase("O", new int[] { 1 })]
        [TestCase("X", new int[] { 3, 5 })]
        public void EnsureXIsOddMovesOisEvenMoves(string player, int[] positions)
        {
            var gameController = new GameController();

            gameController.StartGame();

            foreach (var position in positions)
            {
                gameController.MakeMove((int)position);
            }

            Assert.That(gameController.CurrentPlayer, Is.EqualTo(player));
        }

    }
}