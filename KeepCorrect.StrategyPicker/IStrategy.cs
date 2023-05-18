namespace KeepCorrect.StrategyPicker
{
    public interface IStrategy
    {
        
    }
    
    public interface IStrategyWithDefault : IStrategy
    {
        /// <summary>
        /// Strategy is default
        /// </summary>
        bool IsDefault { get; }
    }
}