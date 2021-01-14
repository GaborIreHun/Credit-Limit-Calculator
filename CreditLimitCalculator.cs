using System;


class CreditLimitCalculator
{
    public int accountNumber;

    public int initialBalance;

    public int charges;

    public int credit;

    public decimal newBalance;

    
    public void SetAccountNumber(int creditLimitCalculatorAccountNumber)
    {
        accountNumber = creditLimitCalculatorAccountNumber;
    }

    public int GetAccountNumber()
    {
        return accountNumber;
    }

    public void SetInitialBalance(int creditLimitCalculatorInitialBalance)
    {
        initialBalance = creditLimitCalculatorInitialBalance;
    }

    public int GetInitialBalance()
    {
        return initialBalance;
    }

    public void SetCharges(int creditLimitCalculatorCharges)
    {
        charges = creditLimitCalculatorCharges;
    }

    public int GetCharges()
    {
        return charges;
    }

    public void SetCredit(int creditLimitCalculatorCredit)
    {
        credit = creditLimitCalculatorCredit;
    }

    public int GetCredit()
    {
        return credit;
    }

    public decimal NewBalance()
    {
        newBalance = initialBalance + credit - charges;

        if (newBalance < 0)
        {
            Console.WriteLine("Credit limit exceeded");
        }

        return newBalance;
    }
    
}
