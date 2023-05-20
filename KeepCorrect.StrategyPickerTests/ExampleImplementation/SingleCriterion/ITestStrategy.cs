using KeepCorrect.StrategyPicker;

namespace KeepCorrect.StrategyPickerTests.ExampleImplementation.SingleCriterion
{
    public interface ITestStrategy : IStrategyWithDefault<StrategyTypeEnum>
    {
    }

    public enum StrategyTypeEnum
    {
        Default,
        First,
        Second
    }
}