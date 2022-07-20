using Microsoft.Extensions.DependencyInjection;
using PackIT.Shared.Abstractions.Commands;
using PackIT.Shared.Commands;

namespace PackIT.Shared
{
    public static class Extensions
    {
        public static IServiceCollection AddCommands(this IServiceCollection services)
        {
            services.AddSingleton<ICommandDispatcher, InMemoryCommandDispatcher>();
            return services;
        }
    }
}