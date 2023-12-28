

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter a string: ");
        string inputString = Console.ReadLine();
        
        for(int i=0;i< inputString.Length;i++){
            Console.WriteLine(inputString[i]);
        }
    }
}