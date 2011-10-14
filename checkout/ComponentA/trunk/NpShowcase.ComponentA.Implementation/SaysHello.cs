using NpShowcase.ComponentA.Contract;

namespace NpShowcase.ComponentA.Implementation
{
    public class SaysHello : ICanSayHello
    {
        public string SayHello()
        {
            return "Component A says hello!";
        }
    }
}