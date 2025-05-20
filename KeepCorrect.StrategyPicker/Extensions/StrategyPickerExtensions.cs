using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace KeepCorrect.StrategyPicker.Extensions;

public static class StrategyPickerExtensions
{
    /// <summary>
    /// Adds the strategy picker to the specified service collection.
    /// </summary>
    /// <param name="services">The service collection to add the strategy picker to.</param>
    /// <returns>The modified service collection.</returns>
    public static IServiceCollection AddStrategyPicker(this IServiceCollection services) =>
        services.AddStrategyPicker(_ => { });

    /// <summary>
    /// Adds the strategy picker to the specified service collection.
    /// </summary>
    /// <param name="services">The service collection to add the strategy picker to.</param>
    /// <param name="configure">The action to configure the strategy picker builder.</param>
    /// <returns>The modified service collection.</returns>
    public static IServiceCollection AddStrategyPicker(this IServiceCollection services,
        Action<IStrategyPickerBuilder> configure)
    {
        if (services == null)
            throw new ArgumentNullException(nameof(services));
        services.TryAdd(ServiceDescriptor.Scoped(typeof(IFactory<>), typeof(Factory<>)));
        services.TryAdd(ServiceDescriptor.Scoped(typeof(IFactory<,>), typeof(Factory<,>)));
        services.TryAdd(ServiceDescriptor.Scoped(typeof(IFactoryWithDefault<>), typeof(FactoryWithDefault<>)));
        services.TryAdd(ServiceDescriptor.Scoped(typeof(IFactoryWithDefault<,>), typeof(FactoryWithDefault<,>)));
        configure(new StrategyPickerBuilder(services));
        return services;
    }

    public interface IStrategyPickerBuilder
    {
        /// <summary>
        /// Gets the <see cref="IServiceCollection"/> where StrategyPicker services are configured.
        /// </summary>
        IServiceCollection Services { get; }
    }
    
    internal sealed class StrategyPickerBuilder : IStrategyPickerBuilder
    {
        public StrategyPickerBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}
    
    

