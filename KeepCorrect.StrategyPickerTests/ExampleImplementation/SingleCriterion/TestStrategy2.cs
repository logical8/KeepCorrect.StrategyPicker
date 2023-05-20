namespace KeepCorrect.StrategyPickerTests.ExampleImplementation.SingleCriterion
{
    public class TestStrategy2 : ITestStrategy
    {
        public bool IsDefault { get; }
        public StrategyTypeEnum StrategyType => StrategyTypeEnum.Second;
    }
}