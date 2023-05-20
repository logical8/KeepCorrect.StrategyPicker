using System.Collections.Generic;
using System.Linq;
using KeepCorrect.StrategyPicker.Exceptions;

namespace KeepCorrect.StrategyPicker
{
    public sealed class Factory<T> : IFactory<T> where T : IStrategy
    {
        private readonly IEnumerable<T> _strategies;

        public Factory(IEnumerable<T> strategies)
        {
            _strategies = strategies;
        }

        public T GetStrategy(IStrategyPicker<T> strategyPicker)
        {
            var strategy = _strategies.FirstOrDefault(strategyPicker.GetConditionsPredicate());
            if (strategy == null) throw new StrategyIsNotImplementedException<T>(strategyPicker);
            return strategy;
        }
    }

    public sealed class FactoryWithDefault<T> : IFactoryWithDefault<T> where T : IStrategyWithDefault
    {
        private readonly IEnumerable<T> _strategies;

        public FactoryWithDefault(IEnumerable<T> strategies)
        {
            _strategies = strategies;
        }

        public T GetStrategyWithDefault(IStrategyPicker<T> strategyPicker)
        {
            var strategy = _strategies.FirstOrDefault(strategyPicker.GetConditionsPredicate());
            if (strategy != null) return strategy;
            strategy = _strategies.FirstOrDefault(s => s.IsDefault);
            if (strategy == null) throw new StrategyIsNotImplementedException<T>(strategyPicker);
            return strategy;
        }
    }
}