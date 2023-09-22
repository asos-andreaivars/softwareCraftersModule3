using NUnit.Framework;
using TicTacToeGame;

namespace TicTacToe.UnitTests
{
    public class GameControllerShould
    {

        [TestCase("X", new object[] { })]
        [TestCase("O", new object[] { 1 })]
        [TestCase("X", new object[] { 3, 5 })]
        public void EnsureXIsOddMovesOisEvenMoves(string player, object[] coordinates)
        {
            var gameController = new GameController();

            gameController.StartGame();

            foreach (var coordinate in coordinates)
            {
                gameController.MakeMove((int)coordinate);
            }

            Assert.That(gameController.CurrentPlayer, Is.EqualTo(player));
        }

    }
}