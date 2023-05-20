namespace KeepCorrect.StrategyPickerTests.ExampleImplementation.MultipleCriteria
{
    public class TestStrategy3 : ITestStrategy
    {
        public bool IsDefault { get; }
        public Criterion1Enum? Criterion1 { get; }
        public Criterion2Enum? Criterion2 => Criterion2Enum.Third;
        public Criterion3Enum? Criterion3 { get; }
        public StrategyTypeEnum StrategyType => StrategyTypeEnum.OnlySecond;
    }
}