using System;

class CreditLimitCalculatorTest
{
    

    static void Main()
    {
        CreditLimitCalculator creditLimitCalculator = new CreditLimitCalculator();


        

        while (true)
        {
            Console.Write("Please enter the relevant account number or -1 to quit: ");
            int creditLimitCalculatortheAccountNumber = int.Parse(Console.ReadLine());
            creditLimitCalculator.SetAccountNumber(creditLimitCalculatortheAccountNumber);

            if (creditLimitCalculatortheAccountNumber == -1)
                break;

            Console.Write("Please enter the relevant beginning balance: ");
            int creditLimitCalculatortheInitialBalance = int.Parse(Console.ReadLine());
            creditLimitCalculator.SetInitialBalance(creditLimitCalculatortheInitialBalance);

            Console.Write("Please enter the relevant charges: ");
            int creditLimitCalculatortheCharges = int.Parse(Console.ReadLine());
            creditLimitCalculator.SetCharges(creditLimitCalculatortheCharges);

            Console.Write("Please enter the relevant credits: ");
            int creditLimitCalculatortheCredit = int.Parse(Console.ReadLine());
            creditLimitCalculator.SetCredit(creditLimitCalculatortheCredit);

            Console.WriteLine($"The customer's new balance is: {creditLimitCalculator.NewBalance()}");

            
        }

        Console.WriteLine("Thank you and see you later!");

        
    }


}

