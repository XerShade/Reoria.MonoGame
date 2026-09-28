using Microsoft.Xna.Framework.Content;
using Reoria.Client.Core.Services.Interfaces;

namespace Reoria.Client.Core.Services;

public class ContentManagerService : IContentManagerService
{
    public virtual ContentManager Content { get; protected set; } = default!;

    public virtual bool IsInitialized
        => this.Content is not null;

    public virtual void Initialize(ContentManager contentManager)
    {
        this.Content = contentManager;
        this.Content.RootDirectory = "Assets";
    }
}