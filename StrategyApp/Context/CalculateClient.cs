using StrategyApp.Strategy.Interface;
namespace StrategyApp.Context
{
    public class CalculateClient
    {
        private ICalculateInterface calculateInterface;
        public CalculateClient(ICalculateInterface strategy)
        {
            calculateInterface = strategy;
        }

        public int Calculate(int value1, int value2)
        {
            return calculateInterface.Calculate(value1, value2);
        }
    }
}
