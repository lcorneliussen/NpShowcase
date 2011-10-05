using NpShowcase.ComponentA.Contract;

namespace NpShowcase.ComponentA.Implementation
{
    public class SomeComponentALogic : ISomeComponentALogic
    {
        public string SayHello()
        {
            return "Component A says hello!";
        }
    }
}