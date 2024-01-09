namespace Delegate.WihtFunc;

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

public class RewardHelper
{
    public Func<int, int> GetStrategy(Person person)
    {
        RewardStrategy strategy = new();

        if (person == Person.Programmer)
            return strategy.CalculateRewardProgrammer;
        else if (person == Person.Manager)
            return strategy.CalculateRewardManager;

        return strategy.CalculateRewardManager;
    }

    public int CalculateReward(Func<int,int> salaryStrategy)
    {
        int amount = 5000;
        return salaryStrategy(amount);
    }
}
