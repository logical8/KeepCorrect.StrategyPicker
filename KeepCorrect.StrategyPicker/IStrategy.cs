namespace KeepCorrect.StrategyPicker
{
    /// <summary>
    /// Strategy interface for using StrategyPicker with multiple criteria
    /// </summary>
    public interface IStrategy
    {
        
    }
    
    /// <summary>
    /// Strategy interface for using StrategyType as single criterion
    /// </summary>
    /// <typeparam name="TStrategyType"></typeparam>
    public interface IStrategy<out TStrategyType> : IStrategy
    {
        TStrategyType StrategyType { get; }
    }
    
    /// <summary>
    /// Strategy interface for using StrategyPicker with multiple criteria.
    /// Can be the default strategy that is selected if the strategy was not found by the StrategyPicker criteria
    /// </summary>
    public interface IStrategyWithDefault : IStrategy
    {
        /// <summary>
        /// Strategy is default
        /// </summary>
        bool IsDefault { get; }
    }
    
    /// <summary>
    /// Strategy interface for using StrategyType as single criterion
    /// Can be the default strategy that is selected if the strategy was not found by the StrategyPicker criteria
    /// </summary>
    public interface IStrategyWithDefault<out TStrategyType> : IStrategy<TStrategyType>
    {
        /// <summary>
        /// Strategy is default
        /// </summary>
        bool IsDefault { get; }
    }
}