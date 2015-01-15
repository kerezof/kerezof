using System;
class AgeAfter10Ys
{
    static void Main()
    {
        Console.Write("Enter your birthday in dd/mm/yyyy format! ");
        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
        var resulut = DateTime.Now.Subtract(userBirthday).Ticks;
        Console.WriteLine("You are {0} years old.", new DateTime(resulut).Year - 1);
        Console.WriteLine("After 10 years you'll be {0} years old.", new DateTime(resulut).AddYears(10).Year - 1);
        Console.ReadLine();
    }
}