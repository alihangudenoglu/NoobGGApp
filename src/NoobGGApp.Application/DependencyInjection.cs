using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NoobGGApp.Application.Common.PipelineBehaviors;
using System.Reflection;

namespace NoobGGApp.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            config.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            // config.AddOpenBehavior(typeof(ValidationBehavior<,>));

            config.AddBehavior(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));

        });
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}