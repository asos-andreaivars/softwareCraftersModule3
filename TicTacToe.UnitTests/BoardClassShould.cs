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

        [Test]
        public void WhenAMoveIsMadeTheBoardIsUpdated()
        {
            var board = new Board();

            board.AddToBoard(1, 'X');
            var visualBoard = board.GetVisualBoard();

            Assert.That(visualBoard, Is.EqualTo("   | X |   \n   |   |   \n   |   |   "));
        }

        [Test]

        public void WhenPlayerHasThreeInRowThePlayerWins()
        {
            var board = new Board();

            board.AddToBoard(0, 'X');
            board.AddToBoard(1, 'X');
            board.AddToBoard(2, 'X');

            

        }
    }
}