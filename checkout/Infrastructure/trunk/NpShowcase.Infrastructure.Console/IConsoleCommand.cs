namespace NpShowcase.Infrastructure.Console
{
    public interface IConsoleCommand
    {
        string Name { get; }
        void Run(string[] args);
    }
}