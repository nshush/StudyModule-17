public interface IAccount
{
    string Type { get; }
    double Balance { get; set; }
    double Interest { get; set; }

    void CalculateInterest();
}

public class RegularAccount : IAccount
{
    public string Type => "Обычный";
    public double Balance { get; set; }
    public double Interest { get; set; }

    public void CalculateInterest()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;
        else if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}

public class SalaryAccount : IAccount
{
    public string Type => "Зарплатный";
    public double Balance { get; set; }
    public double Interest { get; set; }

    public void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}

public static class Calculator
{
    public static void CalculateInterest(IAccount account)
    {
        account.CalculateInterest(); 
    }
}