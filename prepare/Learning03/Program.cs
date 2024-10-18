using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction fration1 = new Fraction();
       Console.WriteLine(fration1.GetFractionString());
       Console.WriteLine(fration1.GetdecimalValue());   

       Fraction fraction2 = new Fraction(5);       
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetdecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetdecimalValue());
       
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetdecimalValue());


    }
}