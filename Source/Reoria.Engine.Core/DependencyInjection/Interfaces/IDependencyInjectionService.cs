using Autofac;

namespace Reoria.Engine.Core.DependencyInjection.Interfaces;

public interface IDependencyInjectionService
{
    ContainerBuilder Builder { get; }
    IContainer Container { get; }

    ILifetimeScope CreateScope();
}