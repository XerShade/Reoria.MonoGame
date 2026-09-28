using Microsoft.Xna.Framework.Content;

namespace Reoria.Client.Core.Services.Interfaces;

public interface IContentManagerService
{
    ContentManager Content { get; }
    bool IsInitialized { get; }

    void Initialize(ContentManager contentManager);
}