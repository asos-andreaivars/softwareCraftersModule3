using TicTacToeGame;

Console.WriteLine("Welcome to a game of TicTacToe!");
var gameController = new GameController();

Console.WriteLine("To make a move, input the number of the position you'd like to play:");
Console.WriteLine("0 being the top left and 9 being the bottom right");
gameController.StartGame();