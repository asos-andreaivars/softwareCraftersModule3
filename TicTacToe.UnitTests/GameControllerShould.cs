using NUnit.Framework;
using TicTacToeGame;

namespace TicTacToe.UnitTests
{
    public class GameControllerShould
    {
        private GameController _sut;
        [SetUp]
        public void SetUp()
        {
            _sut = new GameController();
        }

        [TestCase('X', new int[] { })]
        [TestCase('O', new int[] { 1 })]
        [TestCase('X', new int[] { 3, 5 })]
        public void EnsureXIsOddMovesOIsEvenMoves(char player, int[] positions)
        {
            foreach (var position in positions)
            {
                _sut.MakeMove(position);
            }

            Assert.AreEqual(_sut.CurrentPlayer(), player);
        }

        [Test]
        public void EnsureMoveCannotBeMadeInTheSamePlaceTwice()
        {
            _sut.MakeMove(0);
            _sut.MakeMove(0);

            Assert.AreEqual(_sut.CurrentPlayer(), 'O');
        }
    }
}