using System;
using System.Linq;
using NpShowcase.ComponentB.Contract;
using NpShowcase.Infrastructure.Console;

namespace NpShowcase.ComponentB.Shell
{
    public class BroadCastAShellCommand : IConsoleCommand
    {
        public ISomeComponentBLogic ComponentBLogic { get; set; }

        public string Name
        {
            get { return "repeat-a"; }
        }

        public void Run(string[] args)
        {
            int times = args
                .Take(1)
                .Select(int.Parse)
                .SingleOrDefault();

            Console.WriteLine(ComponentBLogic.BroadcastWhatASays(times));
        }
    }
}