namespace Main;

public class Calculator : IAdd
{
   private int num1 { get; set; }
   private int num2 { get; set; }

   public int Add() => num1 + num2;

   private string GetInput(string message) {
      string text = "";
      while (string.IsNullOrEmpty(text)) {
         Console.Write(message);
         text = Console.ReadLine();
      }
      return text;
   }
}