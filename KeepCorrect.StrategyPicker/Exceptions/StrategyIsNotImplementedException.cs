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