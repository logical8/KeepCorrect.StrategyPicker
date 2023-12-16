using System;

namespace KeepCorrect.StrategyPicker.Exceptions;

public class StrategyNotFoundByConditionsException<T> : Exception where T: IStrategy
{
    public StrategyNotFoundByConditionsException(Func<T, bool> conditionsPredicate) : base(
        $"Strategy not found by conditions predicate {typeof(Func<T, bool>)}: {conditionsPredicate}, " +
        $"or dependencies not registered")
    {
    }
}