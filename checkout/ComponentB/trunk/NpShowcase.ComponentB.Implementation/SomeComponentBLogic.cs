using System.Text;
using NpShowcase.ComponentA.Contract;
using NpShowcase.ComponentB.Contract;

namespace NpShowcase.ComponentB.Implementation
{
    public class SomeComponentBLogic : ISomeComponentBLogic
    {
        /// <summary>
        ///   Please use injection!
        /// </summary>
        public ISomeComponentALogic ComponentALogic { get; set; }

        public string BroadcastWhatASays(int times)
        {
            string hello = ComponentALogic.SayHello();

            var sb = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                sb.AppendLine(hello);
            }
            return sb.ToString();
        }
    }
}