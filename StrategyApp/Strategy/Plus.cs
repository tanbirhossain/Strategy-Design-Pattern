using StrategyApp.Strategy.Interface;

namespace StrategyApp.Strategy
{
    public class Plus : ICalculateInterface
    {
        public int Calculate(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
