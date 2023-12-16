using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace KeepCorrect.StrategyPicker.Extensions;

public static class StrategyPickerExtensions
{
    public static IServiceCollection AddStrategyPicker(this IServiceCollection services) =>
        services.AddStrategyPicker(_ => { });

    public static IServiceCollection AddStrategyPicker(this IServiceCollection services,
        Action<IStrategyPickerBuilder> configure)
    {
        if (services == null)
            throw new ArgumentNullException(nameof(services));
        services.TryAdd(ServiceDescriptor.Singleton(typeof(IFactory<>), typeof(Factory<>)));
        services.TryAdd(ServiceDescriptor.Singleton(typeof(IFactory<,>), typeof(Factory<,>)));
        services.TryAdd(ServiceDescriptor.Singleton(typeof(IFactoryWithDefault<>), typeof(FactoryWithDefault<>)));
        services.TryAdd(ServiceDescriptor.Singleton(typeof(IFactoryWithDefault<,>), typeof(FactoryWithDefault<,>)));
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
    
    

