using System;
using NpShowcase.ComponentA.Contract;

namespace NpShowcase.ComponentA.Shell
{
    public class SayHelloShellCommand : Infrastructure.Console.IConsoleCommand
    {
        public ISomeComponentALogic ComponentALogic { get; set; }

        public string Name
        {
            get { return "say-hello"; }
        }

        public void Run(string[] args)
        {
            Console.WriteLine(ComponentALogic.SayHello());
        }
    }
}