using System;
using System.Collections.Generic;
using System.Linq;
using NpShowcase.ComponentA.Implementation;
using NpShowcase.ComponentA.Shell;
using NpShowcase.ComponentB.Implementation;
using NpShowcase.ComponentB.Shell;
using NpShowcase.Infrastructure.Console;

namespace NpShowcase.Shell.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<IConsoleCommand> commands = doWhatIoCShouldDo();

            if (args.Length == 0)
            {
                System.Console.WriteLine("available commands: "
                                         + String.Join(", ", commands.Select(c => c.Name)));
            }
            else
            {
                string commandName = args.First();
                string[] commandArgs = args.Skip(1).ToArray();


                commands.Where(c => c.Name == commandName)
                    .Single()
                    .Run(commandArgs);
            }
        }

        private static IEnumerable<IConsoleCommand> doWhatIoCShouldDo()
        {
            var a = new SaysHello();
            var b = new BroadcastsA { ComponentALogic = a };

            yield return new SayHelloShellCommand { ComponentALogic = a };
            yield return new BroadCastAShellCommand { ComponentBLogic = b };
        }
    }
}