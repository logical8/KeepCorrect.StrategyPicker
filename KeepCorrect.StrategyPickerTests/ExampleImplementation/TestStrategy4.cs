namespace KeepCorrect.StrategyPickerTests.ExampleImplementation
{
    public class TestStrategy4 : ITestStrategy
    {
        public bool IsDefault { get; }
        public Criterion1Enum? Criterion1 { get; } = Criterion1Enum.Third;
        public Criterion2Enum? Criterion2 { get; }
        public Criterion3Enum? Criterion3 { get; }
        public StrategyTypeEnum StrategyType { get; } = StrategyTypeEnum.OnlyFirst;
    }
}