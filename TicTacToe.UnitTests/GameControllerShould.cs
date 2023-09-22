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
    }

}