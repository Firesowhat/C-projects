using System;
using MyNamespace;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");//Hello world

        string phrase = "Giraffe Academy";//(phrase.Contains) is a method checking if Academy is in the phrase
        Console.WriteLine(phrase.Contains("Academy"));
        Console.WriteLine(phrase.IndexOf("G"));//gives you the number position of the letter
        Console.WriteLine(phrase.Substring(0, 2));//a length of characters starting from range 0 up to 2

        Console.Write("Enter your name:");
        string name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Hello " + name);

        int num = Convert.ToInt32("42");
        Console.WriteLine(6 + num);

        int[] luckyNumbers = {1, 2, 3, 4, 5, 6};
        string[] friends = new string[5];
        friends[0] = "Naa";
        friends[1] = "Akuyea";
        Console.WriteLine(luckyNumbers[1]);

        string secretWord = "giraffe";
        string guess = "";

        while (guess != secretWord){
           Console.WriteLine("Enter guess: ");
           guess = Console.ReadLine() ?? string.Empty;
           
        }
        Console.WriteLine("You Win!");
         
         MyBook book1 = new MyBook("Bible", "Holy Spirit", 1000);

        
    }
}