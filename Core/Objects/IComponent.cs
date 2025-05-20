using Sitta.Core.Rules;

namespace Sitta.Core.Objects
{
    internal interface IComponent
    {
        public string Name { get; }
        public IRuleset Ruleset { get; }
        public void Move();

        public IEnumerable<IComponent> Belongings { get; }
    }

    internal interface ICard : IComponent, IFlippable
    {

    }

    internal interface IToken : IComponent
    {

    }

    internal interface IHaveState<TState>
    {
        public TState State { get; }
        public void Change(TState newState);
    }

    internal interface IFlippable : IHaveState<FlippableStates>
    {

    }

    internal enum FlippableStates : byte
    {
        None = 0,
        Face = 1,
        Back = 2,
    }
}