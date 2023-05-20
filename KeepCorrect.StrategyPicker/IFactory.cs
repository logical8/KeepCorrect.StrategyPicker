namespace KeepCorrect.StrategyPicker
{
    /// <summary>
    /// Factory that returns strategy using strategy picker implementation.
    /// Use this when you need to choose strategy by multiple criteria 
    /// </summary>
    /// <typeparam name="TStrategy"></typeparam>
    public interface IFactory<out TStrategy> where TStrategy : IStrategy
    {
        /// <summary>
        /// Get an instance of a strategy using the conditions described in StrategyPicker
        /// </summary>
        /// <param name="strategyPicker"></param>
        /// <returns></returns>
        TStrategy GetStrategy(IStrategyPicker<TStrategy> strategyPicker);
    }
    
    /// <summary>
    /// Simple factory that returns strategy using strategy type.
    /// Use this when you need to choose strategy by single criterion (usually some Enum)
    /// </summary>
    /// <typeparam name="TStrategy"></typeparam>
    /// <typeparam name="TStrategyType"></typeparam>
    public interface IFactory<out TStrategy, in TStrategyType> where TStrategy : IStrategy<TStrategyType>
    {
        /// <summary>
        /// Get an instance of a strategy using strategy type
        /// </summary>
        /// <param name="strategyType"></param>
        /// <returns></returns>
        TStrategy GetStrategy(TStrategyType strategyType);
    }
    
    public interface IFactoryWithDefault<out TStrategy> where TStrategy : IStrategyWithDefault
        
    {
        /// <summary>
        /// Get an instance of the strategy using the conditions described in the StrategyPicker.
        /// In case of failure, select the default strategy
        /// </summary>
        /// <param name="strategyPicker"></param>
        /// <returns></returns>
        TStrategy GetStrategyWithDefault(IStrategyPicker<TStrategy> strategyPicker);
    }
    
    public interface IFactoryWithDefault<out TStrategy, in TStrategyType> where TStrategy : IStrategyWithDefault<TStrategyType>
    {
        /// <summary>
        /// Get an instance of the strategy using the conditions described in the StrategyPicker.
        /// In case of failure, select the default strategy
        /// </summary>
        /// <param name="strategyType"></param>
        /// <returns></returns>
        TStrategy GetStrategyWithDefault(TStrategyType strategyType);
    }
}