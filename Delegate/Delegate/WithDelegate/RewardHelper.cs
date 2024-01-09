namespace Delegate.WihtDelegate;

public class RewardStrategy
{
    public int CalculateRewardProgrammer(int amount)
    {
        return amount * 2;
    }

    public int CalculateRewardManager(int amount)
    {
        return amount * 4;
    }
}

public delegate int SalaryStrategy(int amount);

public class RewardHelper
{
    public SalaryStrategy GetStrategy(Person person)
    {
        RewardStrategy strategy = new();

        if (person == Person.Programmer)
            return strategy.CalculateRewardProgrammer;
        else if (person == Person.Manager)
            return strategy.CalculateRewardManager;

        return strategy.CalculateRewardManager;
    }

    public int CalculateReward(SalaryStrategy salaryStrategy)
    {
        int amount = 5000;
        return salaryStrategy(amount);
    }
}
