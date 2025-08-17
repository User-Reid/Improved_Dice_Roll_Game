var random = new Random();
int diceRoll = random.Next(1, 7);

Console.ReadLine();

class Dice
{
  private readonly Random _random;

  public Dice(Random random)
  {
    _random = random;
  }

  public int Roll()
  {
    return _random.Next(1, 7);
  }
}