var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

Results gameResult = guessingGame.Play();
guessingGame.PrintResult(gameResult);

Console.ReadLine();

public enum Results
  {
    Win,
    Lose,
    Tie,
  }

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

  public void PrintResult(Results gameResult)
  {
    string message = gameResult == Results.Win
    ? message = "Congrats! You have won!🎊" 
    : message = "You have lost ya dang dummy!";
    
    System.Console.WriteLine(message);
  }
}

public static class ConsoleReader
{
public static int ReadIntiger(string message)
{
  int result;
  do
  {
    System.Console.WriteLine(message);
  } while (!int.TryParse(Console.ReadLine(), out result));
  return result;
}
}

public class Dice
{
  private readonly Random _random;
  private const int SidesOfDice = 6;

  public Dice(Random random)
  {
    _random = random;
  }

  public int Roll() => _random.Next(1, SidesOfDice + 1);
  public void Describe() => System.Console.WriteLine($"This is a dice with {SidesOfDice} sides");

}