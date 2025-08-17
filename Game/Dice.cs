namespace Improved_Dice_Roll_Game
{
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
}