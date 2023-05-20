namespace KeepCorrect.StrategyPickerTests.ExampleImplementation.SingleCriterion
{
    public class TestStrategy1 : ITestStrategy
    {
        public bool IsDefault { get; }
        public StrategyTypeEnum StrategyType => StrategyTypeEnum.First;
    }
}