namespace KeepCorrect.StrategyPickerTests.ExampleImplementation.MultipleCriteria
{
    public class TestStrategy1 : ITestStrategy
    {
        public bool IsDefault { get; }
        public Criterion1Enum? Criterion1 => Criterion1Enum.First;
        public Criterion2Enum? Criterion2 => Criterion2Enum.First;
        public Criterion3Enum? Criterion3 => Criterion3Enum.First;
        public StrategyTypeEnum StrategyType => StrategyTypeEnum.All;
    }
}