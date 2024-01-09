namespace Delegate.WithoutDelegate;

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
    public int CalculateReward(Person person)
    {
        int amount = 5000;

        RewardStrategy strategy = new();

        if (person == Person.Programmer)
            return strategy.CalculateRewardProgrammer(amount);
        else if (person == Person.Manager)
            return strategy.CalculateRewardManager(amount);

        return strategy.CalculateRewardProgrammer(amount);
    }
}
