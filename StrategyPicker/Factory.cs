using System;
using System.Linq;

namespace StrategyPicker
{
    public sealed class Factory<T, TStrategyPicker> : IFactory<T, TStrategyPicker> where T : IStrategy
        where TStrategyPicker : IStrategyPicker<T>
    {
        private readonly T[] _strategies;

        public Factory(T[] strategies)
        {
            _strategies = strategies;
        }

        public T GetStrategy(TStrategyPicker strategyPicker)
        {
            var strategy = _strategies.FirstOrDefault(strategyPicker.GetConditionsPredicate());
            if (strategy == null)
                throw new NotImplementedException(
                    $"Factory instance not implemented for {typeof (TStrategyPicker)}: {strategyPicker}, or dependencies not registered");
            return strategy;
        }
    }
    
    public sealed class FactoryWithDefault<T, TStrategyPicker> : IFactoryWithDefault<T, TStrategyPicker> where T : IStrategyWithDefault
        where TStrategyPicker : IStrategyPicker<T>
    {
        private readonly T[] _strategies;

        public FactoryWithDefault(T[] strategies)
        {
            _strategies = strategies;
        }
        
        public T GetStrategyWithDefault(TStrategyPicker strategyPicker)
        {
            var strategy = _strategies.FirstOrDefault(strategyPicker.GetConditionsPredicate());
            if (strategy == null)
            {
                strategy = _strategies.FirstOrDefault(s => s.IsDefault);
                if (strategy == null)
                    throw new NotImplementedException(
                        $"Factory instance not implemented for {typeof (TStrategyPicker)}: {strategyPicker}, or dependencies not registered");
            }
            return strategy;
        }
    }
}