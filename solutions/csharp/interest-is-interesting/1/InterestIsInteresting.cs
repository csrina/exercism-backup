static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance switch
    {
        < 0 => 3.213f,
        >= 0 and < 1000 => 0.5f,
        >= 1000 and < 5000 => 1.621f,
        _ => 2.475f,
    };

    public static decimal Interest(decimal balance)
    {
        return balance * Convert.ToDecimal(InterestRate(balance)) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var currentB = balance;
        var yearCount = 0;
        while (currentB < targetBalance)
        {
            currentB = AnnualBalanceUpdate(currentB);
            yearCount++;
        }
        return yearCount;
    }
}
