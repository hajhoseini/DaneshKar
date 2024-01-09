using Delegate_Func_Sample.WihtDelegate;

namespace Delegate_Func_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region WithoutDelegate

            Delegate_Func_Sample.Simple.RewardHelper helper1 = new();
            int result1 = helper1.CalculateReward(Person.Programmer);

            #endregion

            #region WithDelegate

            Delegate_Func_Sample.WihtDelegate.RewardHelper helper2 = new();
            SalaryStrategy strategy = helper2.GetStrategy(Person.Programmer);
            int result2 = helper2.CalculateReward(strategy);

            #endregion

            #region WithFunc

            Delegate_Func_Sample.WihtFunc.RewardHelper helper3 = new();
            Func<int, int> strategy3 = helper3.GetStrategy(Person.Programmer);
            int result23 = helper2.CalculateReward(strategy);

            #endregion
        }
    }
}