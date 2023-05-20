namespace KeepCorrect.StrategyPickerTests.ExampleImplementation
{
    public class TestStrategy2 : ITestStrategy
    {
        public bool IsDefault { get; }
        public Criterion1Enum? Criterion1 => Criterion1Enum.Second;
        public Criterion2Enum? Criterion2 => Criterion2Enum.Second;
        public Criterion3Enum? Criterion3 { get; }
        public StrategyTypeEnum StrategyType => StrategyTypeEnum.FirstAndSecond;
    }
}