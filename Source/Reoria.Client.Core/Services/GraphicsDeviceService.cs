using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using IGraphicsDeviceService = Reoria.Client.Core.Services.Interfaces.IGraphicsDeviceService;

namespace Reoria.Client.Core.Services;

public class GraphicsDeviceService : IGraphicsDeviceService
{
    public virtual GraphicsDevice Device { get; protected set; } = default!;
    public virtual GraphicsDeviceManager Manager { get; protected set; } = default!;

    public virtual bool IsInitialized 
        => this.Device is not null 
        && this.Manager is not null;

    public virtual void Initialize(GraphicsDevice graphicsDevice, GraphicsDeviceManager graphicsDeviceManager)
    {
        this.Device = graphicsDevice;
        this.Manager = graphicsDeviceManager;
    }

    public virtual void Clear(Color color)
        => this.Device.Clear(color);
}