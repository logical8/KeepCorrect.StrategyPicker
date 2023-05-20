namespace KeepCorrect.StrategyPicker
{
    public interface IFactory<out TStrategy> where TStrategy : IStrategy
    {
        /// <summary>
        /// Get an instance of a strategy using the conditions described in StrategyPicker
        /// </summary>
        /// <param name="strategyPicker"></param>
        /// <returns></returns>
        TStrategy GetStrategy(IStrategyPicker<TStrategy> strategyPicker);
    }
    
    public interface IFactoryWithDefault<out TStrategy> where TStrategy : IStrategyWithDefault
        
    {
        /// <summary>
        /// Get an instance of the strategy using the conditions described in the StrategyPicker, in case of failure, select the default strategy
        /// </summary>
        /// <param name="strategyPicker"></param>
        /// <returns></returns>
        TStrategy GetStrategyWithDefault(IStrategyPicker<TStrategy> strategyPicker);
    }
}