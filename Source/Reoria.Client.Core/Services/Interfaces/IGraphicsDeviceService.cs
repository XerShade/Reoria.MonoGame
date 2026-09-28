using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Reoria.Client.Core.Services.Interfaces;

public interface IGraphicsDeviceService
{
    GraphicsDevice Device { get; }
    GraphicsDeviceManager Manager { get; }
    bool IsInitialized { get; }

    void Clear(Color color);
    void Initialize(GraphicsDevice graphicsDevice, GraphicsDeviceManager graphicsDeviceManager);
}