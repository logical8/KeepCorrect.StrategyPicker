namespace KeepCorrect.StrategyPickerTests.ExampleImplementation
{
    public class TestStrategyDefault : ITestStrategy
    {
        public bool IsDefault => true;
        public Criterion1Enum? Criterion1 { get; }
        public Criterion2Enum? Criterion2 { get; }
        public Criterion3Enum? Criterion3 { get; }
        public StrategyTypeEnum StrategyType => StrategyTypeEnum.Default;
    }
}