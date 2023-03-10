namespace Main;

public class Logger : ILogger
{
   public void Error(string message)
   {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(message);
   }

   public void Event(string message)
   {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine(message);
   }
}