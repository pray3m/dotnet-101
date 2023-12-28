using System;

class Sum
{
    public int a;
    public int b;
    int result = 0;
    

    public void CalcSum()
    {
        result = a + b;
        Console.WriteLine($"Sum is : {result}"); 
        
    }
}

class OOPConcepts
{
    public static void Main()
    {
        Sum obj = new Sum();
        obj.a=10;
        obj.b =20;
        obj.CalcSum();
    }
}