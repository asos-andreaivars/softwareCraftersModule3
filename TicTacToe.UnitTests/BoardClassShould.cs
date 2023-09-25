using NUnit.Framework;
using TicTacToeGame;

namespace TicTacToe.UnitTests
{
    public class BoardClassShould
    {

        [Test]
        public void CreateAnEmptyBoardGivenNoMovesHaveBeenMade()
        {
            var board = new Board();

            var visualBoard = board.GetVisualBoard();

            Assert.That(visualBoard, Is.EqualTo("   |   |   \n   |   |   \n   |   |   "));

        }

        [TestCase(new char[] { 'X' }, new int[] { 1 }, "   | X |   \n   |   |   \n   |   |   ")]
        [TestCase(new char[] { 'X', 'O' }, new int[] { 1, 2 }, "   | X | O \n   |   |   \n   |   |   ")]
        [TestCase(new char[] { 'X', 'O', 'X' }, new int[] { 1, 2, 0 }, " X | X | O \n   |   |   \n   |   |   ")]
        public void WhenMovesAreMadeTheBoardIsUpdated(char[] players, int[] positions, string result)
        {
            var board = new Board();

            for(int i = 0; i < players.Length; i++)
            {
                board.AddToBoard(positions[i], players[i]);
            }

            var visualBoard = board.GetVisualBoard();

            Assert.AreEqual(result, visualBoard.ToString());
        }
    }
}