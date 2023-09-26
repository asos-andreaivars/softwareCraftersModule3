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

        [Test]
        public void WhenNoMovesAvailableAndNoOneHasWonGameIsDrawn()
        {
            _sut.MakeMove(0);
            _sut.MakeMove(1);
            _sut.MakeMove(2);
            _sut.MakeMove(4);
            _sut.MakeMove(3);
            _sut.MakeMove(6);
            _sut.MakeMove(7);
            _sut.MakeMove(8);
            _sut.MakeMove(5);

            Assert.IsTrue(_sut.IsComplete);
            Assert.IsFalse(_sut.HasWinner);
        }

        [TestCase(new int[] { 0, 3, 1, 4, 2 })]
        [TestCase(new int[] { 0, 2, 3, 4, 6 })]
        [TestCase(new int[] { 0, 2, 4, 3, 8 })]
        public void WhenThreeInARowThenGameIsWon(int[] moves)
        {
            foreach (int move in moves)
            {
                _sut.MakeMove(move);
            }

            Assert.IsTrue(_sut.IsComplete);
            Assert.IsTrue(_sut.HasWinner);
        }
    }
}