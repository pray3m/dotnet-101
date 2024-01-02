using System;

public class MethodOverriding
{
    public static void Main()
    {
        SavingAccount s = new SavingAccount();
        CheckingAccount c = new CheckingAccount();

        double interestS = s.CalcInterest(1000);
        double interestC = c.CalcInterest(1000);

        Console.WriteLine($"The interest for savings acc : {interestS}");
        Console.WriteLine($"The interest for checking acc : {interestC}");

    }

}

class Account
{
    public virtual double CalcInterest(double balance)
    {
        return balance * 0.02;
    }
}

class SavingAccount : Account
{
    public override double CalcInterest(double balance)
    {
        return balance * 0.05;
    }

}

class CheckingAccount : Account
{
    public override double CalcInterest(double balance)
    {
        return balance * 0.01;
    }

}

