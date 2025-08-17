namespace Improved_Dice_Roll_Game
{

  public class GuessingGame
  {

    private const int InitialTries = 3;
    private readonly Dice _dice;
    public GuessingGame(Dice dice)
    {
      _dice = dice;
    }

    public Results Play()
    {

      var diceRollResult = _dice.Roll();
      int tries = InitialTries;
      System.Console.WriteLine($"Dice Rolled. Guess what number it shows in {InitialTries} tries!");
      while (tries > 0)
      {
        var guess = ConsoleReader.ReadIntiger("Enter a number:");
        if (guess == diceRollResult)
        {
          System.Console.WriteLine("You won! Congrats!🎊");
          return Results.Win;
        }
        System.Console.WriteLine("You failed you dumb nincompoop💩💀");
        tries--;
      }
      return Results.Lose;
    }

    public static void PrintResult(Results gameResult)
    {
      string message = gameResult == Results.Win
      ? message = "Congrats! You have won!🎊"
      : message = "You have lost ya dang dummy!";

      System.Console.WriteLine(message);
    }
  }
}