// using System;

// class MultipleInheritance
// {
//     public static void Main()
//     {
//         Calculation c = new Calculation();
//         c.a = 20;
//         c.b = 30;
//         Console.WriteLine(c.sum());
//         Console.WriteLine(c.diff());

//     }
// }

// class Addition
// {
//     int a;
//     int b;
//     public int sum()
//     {
//         return a + b;
//     }
// }

// interface Difference
// {
//     int x;
//     int y;
//     public int diff();
// }


// class Calculation : Addition, Difference
// {
//     int x = 20;
//     int y = 10;
//     public int diff()
//     {
//         return x - y;
//     }
// }