namespace KeepCorrect.StrategyPickerTests.ExampleImplementation
{
    public class TestStrategy3 : ITestStrategy
    {
        public bool IsDefault { get; }
        public Criterion1Enum? Criterion1 { get; }
        public Criterion2Enum? Criterion2 { get; } = Criterion2Enum.Third;
        public Criterion3Enum? Criterion3 { get; }
        public StrategyTypeEnum StrategyType { get; } = StrategyTypeEnum.OnlySecond;
    }
}