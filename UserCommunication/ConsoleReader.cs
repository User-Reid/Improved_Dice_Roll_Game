namespace Improved_Dice_Roll_Game.UserCommunication
{
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
}