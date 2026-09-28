using Autofac;
using Reoria.Engine.Core.DependencyInjection.Interfaces;

namespace Reoria.Engine.Core.DependencyInjection;

public class DependencyInjectionService : IDependencyInjectionService
{
    public virtual ContainerBuilder Builder { get; private set; } = new();
    public virtual IContainer Container { get; private set; } = default!;

    protected virtual bool BuildContainer()
    {
        if (this.Container is not null)
        {
            return true;
        }

        try
        {
            this.Container = this.Builder.Build();
            return true;
        }
        catch (Exception ex)
        {
            // TODO: Implement actual logging later, for now just spit it out to the console.
            Console.WriteLine($"Error building dependency injection container: {ex.Message}");
            return false;
        }
    }

    public ILifetimeScope CreateScope() 
        => this.BuildContainer()
            ? this.Container is not null
            ? this.Container.BeginLifetimeScope()
            : throw new Exception("Unable to create dependency injection scope: The dependency injection container is null.")
            : throw new Exception("Unable to create dependency injection scope: The dependency injection container could not be built.");
}