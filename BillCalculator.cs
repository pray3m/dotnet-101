using System;

class BillCalculator
{
    public static void Main()
    {

        double total_price = 0.0;
        double discount_percentage = 0.0;
        double vat_percentage = 0.13;
        double final_bill_amount = 0.0;


        while (true)
        {
            Console.Write("Enter the price of an item (or -1 to quit): ");
            double item_price = double.Parse(Console.ReadLine());

            if (item_price == -1)
            {
                break;
            }
            else
            {
                total_price += item_price;
            }
        }

        Console.Write("Enter the discount percentage: ");
        discount_percentage = double.Parse(Console.ReadLine());


        double discount_amount = total_price * discount_percentage / 100;
        total_price -= discount_amount;


        double vat_amount = total_price * vat_percentage;


        final_bill_amount = total_price + vat_amount;

        Console.WriteLine("------------------------------------");
        Console.WriteLine("Total price before discount: $" + total_price.ToString("F2"));
        Console.WriteLine("Discount amount: $" + discount_amount.ToString("F2"));
        Console.WriteLine("Total price after discount: $" + (total_price - discount_amount).ToString("F2"));
        Console.WriteLine("VAT amount: $" + vat_amount.ToString("F2"));
        Console.WriteLine("Final bill amount: $" + final_bill_amount.ToString("F2"));
    }
}
