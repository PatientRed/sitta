namespace Sitta.Core.Rules
{
    internal interface IRuleset
    {
        public IEnumerable<IRule> Rules { get; }

        public void AddRule(IRule rule);
        public void RemoveRule(IRule rule);
    }

    internal interface IRule
    {
        public bool Applicable { get; }
    }

    internal interface IGameplay : IRuleset
    {
        public IFlow Flow { get; }
    }
}
