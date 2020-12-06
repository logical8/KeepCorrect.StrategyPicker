namespace StrategyPickerTests.ExampleImplementation
{
    public class TestStrategy1 : ITestStrategy
    {
        public bool IsDefault { get; }
        public Criterion1Enum? Criterion1 { get; } = Criterion1Enum.First;
        public Criterion2Enum? Criterion2 { get; } = Criterion2Enum.First;
        public Criterion3Enum? Criterion3 { get; } = Criterion3Enum.First;
        public StrategyTypeEnum StrategyType { get; } = StrategyTypeEnum.All;
    }
}