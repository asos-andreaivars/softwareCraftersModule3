using NUnit.Framework;
using TicTacToeGame;

namespace TicTacToe.UnitTests
{
    public class GameControllerShould
    {
        [Test]
        public void EnsureXGoesFirst()
        {
            var gameController = new GameController();

            gameController.StartGame();

            Assert.That(gameController.CurrentPlayer, Is.EqualTo("X"));
        }

        [Test]
        public void EnsureOGoesSecond()
        {
            var gameController = new GameController();

            gameController.StartGame();

            gameController.MakeMove(0, 0);

            Assert.That(gameController.CurrentPlayer, Is.EqualTo("O"));
        }

        [Test]
        public void EnsureXGoesThird()
        {
            var gameController = new GameController();

            gameController.StartGame();

            gameController.MakeMove(0, 1);

            Assert.That(gameController.CurrentPlayer, Is.EqualTo("X"));
        }
    }
}