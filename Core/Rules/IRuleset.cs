namespace Sitta.Core.Rules
{
    public interface IRuleset
    {
        public IEnumerable<IRule> Rules { get; }

        public void AddRule(IRule rule);
        public void RemoveRule(IRule rule);
    }

    public interface IRule
    {
        public delegate Action Perform();

        public bool Applicable { get; }
    }

    public interface IGameplay : IRuleset
    {
        public ISetup Setup { get; }

        public IFlow Flow { get; }
    }

    public interface ISetup : IRuleset { }

    public interface IState { }
}
