using Improved_Dice_Roll_Game;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

Results gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

Console.ReadLine();