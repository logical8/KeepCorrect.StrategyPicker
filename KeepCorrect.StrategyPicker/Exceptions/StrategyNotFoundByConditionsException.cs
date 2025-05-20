using System;

namespace KeepCorrect.StrategyPicker.Exceptions;

/// <summary>
/// Represents an exception that is thrown when a strategy is not found based on specified conditions.
/// </summary>
/// <typeparam name="T">The type of the strategy.</typeparam>
public class StrategyNotFoundByConditionsException<T> : Exception where T: IStrategy
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StrategyNotFoundByConditionsException{T}"/> class
    /// with the specified conditions predicate.
    /// </summary>
    /// <param name="conditionsPredicate">The conditions predicate used to search for the strategy.</param>
    public StrategyNotFoundByConditionsException(Func<T, bool> conditionsPredicate) : base(
        $"Strategy not found by conditions predicate {typeof(Func<T, bool>)}: {conditionsPredicate}, " +
        $"or dependencies not registered")
    {
    }
}