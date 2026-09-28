using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Reoria.Client.Core.Services.Interfaces;

public interface ISpriteBatchService
{
    SpriteBatch Batch { get; }
    bool IsInitialized { get; }

    void Initialize();
    void OnPostRender(GameTime gameTime);
    void OnPreRender(GameTime gameTime);
}