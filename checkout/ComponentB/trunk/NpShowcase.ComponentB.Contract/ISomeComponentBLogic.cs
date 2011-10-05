namespace NpShowcase.ComponentB.Contract
{
    public interface ISomeComponentBLogic
    {
        /// <summary>
        ///   I know A, conceptually, but I do not really know how and when A will deliver what I need.
        /// </summary>
        string BroadcastWhatASays(int times);
    }
}