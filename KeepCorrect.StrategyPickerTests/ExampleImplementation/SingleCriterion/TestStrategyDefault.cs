namespace KeepCorrect.StrategyPickerTests.ExampleImplementation.SingleCriterion
{
    public class TestStrategyDefault : ITestStrategy
    {
        public bool IsDefault => true;
        public StrategyTypeEnum StrategyType => StrategyTypeEnum.Default;
    }
}