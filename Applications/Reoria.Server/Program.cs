namespace Reoria.Server;

/// <summary>
/// Entry point for the Reoria Server application.
/// </summary>
/// <remarks>
/// This program initializes and runs the Reoria multiplayer game server. The server handles client connections, game state
/// synchronization, and server-authoritative game logic processing.
/// </remarks>
public static class Program
{
    /// <summary>
    /// The main entry point for the server application.
    /// </summary>
    /// <param name="args">Command line arguments passed to the server application.</param>
    /// <returns>Exit code indicating server termination status.</returns>
    public static int Main(string[] args)
    {
        try
        {
            // We kind of don't have a server yet, but we have a server application entry point!
            return 0; // Successful exit
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Fatal error starting server: {ex.Message}");
            Console.Error.WriteLine($"Stack trace: {ex.StackTrace}");
            return ex.HResult; // Error exit code
        }
    }
}