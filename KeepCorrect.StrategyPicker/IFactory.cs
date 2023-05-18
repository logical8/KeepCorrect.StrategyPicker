namespace KeepCorrect.StrategyPicker
{
    public interface IFactory<out TStrategy, in TStrategyPicker> where TStrategyPicker : IStrategyPicker<TStrategy>
    {
        /// <summary>
        /// Get an instance of a strategy using the conditions described in StrategyPicker
        /// </summary>
        /// <param name="strategyPicker"></param>
        /// <returns></returns>
        TStrategy GetStrategy(TStrategyPicker strategyPicker);
    }
    
    public interface IFactoryWithDefault<out TStrategy, in TStrategyPicker> where TStrategy : IStrategyWithDefault where TStrategyPicker : IStrategyPicker<TStrategy>
        
    {
        /// <summary>
        /// Get an instance of the strategy using the conditions described in the StrategyPicker, in case of failure, select the default strategy
        /// </summary>
        /// <param name="strategyPicker"></param>
        /// <returns></returns>
        TStrategy GetStrategyWithDefault(TStrategyPicker strategyPicker);
    }
}