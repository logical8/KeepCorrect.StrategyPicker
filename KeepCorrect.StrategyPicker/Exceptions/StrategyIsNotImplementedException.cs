using System;

namespace KeepCorrect.StrategyPicker.Exceptions;

public class StrategyIsNotImplementedException<T> : Exception where T: IStrategy
{
    public StrategyIsNotImplementedException(IStrategyPicker<T> strategyPicker) : base(
        $"Strategy instance not implemented for {typeof(IStrategyPicker<T>)}: {strategyPicker}, " +
        $"or dependencies not registered")
    {
    }
}

public class StrategyIsNotImplementedException<T, TK> : Exception where T: IStrategy<TK>
{
    public StrategyIsNotImplementedException(TK strategyType) : base(
        $"Strategy instance not implemented for {typeof(TK)}: {strategyType}, " +
        $"or dependencies not registered")
    {
    }
}