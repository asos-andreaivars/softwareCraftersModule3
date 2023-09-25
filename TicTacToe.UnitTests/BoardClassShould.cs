using NUnit.Framework;
using TicTacToeGame;

namespace TicTacToe.UnitTests
{
    public class BoardClassShould
    {
        private Board _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new Board();
        }

        [Test]
        public void CreateAnEmptyBoardGivenNoMovesHaveBeenMade()
        {
            var visualBoard = _sut.GetVisualBoard();

            Assert.That(visualBoard, Is.EqualTo("   |   |   \n   |   |   \n   |   |   "));
        }

        [TestCase(new char[] { 'X' }, new int[] { 1 }, "   | X |   \n   |   |   \n   |   |   ")]
        [TestCase(new char[] { 'X', 'O' }, new int[] { 1, 2 }, "   | X | O \n   |   |   \n   |   |   ")]
        [TestCase(new char[] { 'X', 'O', 'X' }, new int[] { 1, 2, 0 }, " X | X | O \n   |   |   \n   |   |   ")]
        public void WhenMovesAreMadeTheBoardIsUpdated(char[] players, int[] positions, string result)
        {
            for(int i = 0; i < players.Length; i++)
            {
                _sut.AddToBoard(positions[i], players[i]);
            }

            var visualBoard = _sut.GetVisualBoard();

            Assert.AreEqual(result, visualBoard.ToString());
        }

        [Test]
        public void WhenMoveIsMadeAndPlayerHasAlreadyPlayedThereThenMoveNotMade()
        {
            _sut.AddToBoard(0, 'X');
            _sut.AddToBoard(0, 'O');

            var visualBoard = _sut.GetVisualBoard();

            Assert.AreEqual("   | X |   \n   |   |   \n   |   |   ", visualBoard.ToString());
        }
    }
}