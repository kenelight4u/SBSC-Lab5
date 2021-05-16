using System;

namespace LabFive
{
    class Program
    {
        static void Main(string[] args)
        {
            BankA bankA = new BankA();
            Console.WriteLine($"The Balance in Bank A is: {bankA.GetBalance()}");

            BankB bankB = new BankB();
            Console.WriteLine($"The Balance in Bank B is: {bankB.GetBalance()}");

            BankC bankC = new BankC();
            Console.WriteLine($"The Balance in Bank C is: {bankC.GetBalance()}");
        }
    }
}
