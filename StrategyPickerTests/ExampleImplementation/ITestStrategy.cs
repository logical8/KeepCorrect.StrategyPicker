using StrategyPicker;

namespace StrategyPickerTests.ExampleImplementation
{
    public interface ITestStrategy : IStrategyWithDefault
    {
        Criterion1Enum? Criterion1 { get; }
        Criterion2Enum? Criterion2 { get; }
        Criterion3Enum? Criterion3 { get; }

        StrategyTypeEnum StrategyType { get; }
    }

    public enum Criterion1Enum
    {
        Default,
        First,
        Second,
        Third
    }
    
    public enum Criterion2Enum
    {
        Default,
        First,
        Second,
        Third
    }
    
    public enum Criterion3Enum
    {
        Default,
        First,
        Second,
        Third
    }

    public enum StrategyTypeEnum
    {
        Default,
        All,
        OnlyFirst,
        FirstAndSecond,
        OnlySecond,
    }
}