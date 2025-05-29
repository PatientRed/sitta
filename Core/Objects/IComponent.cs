using Sitta.Core.Rules;

namespace Sitta.Core.Objects
{
    public interface IComponent
    {
        public string Name { get; }

        public IPropertyContainer Properties { get; }

        public IEnumerable<IComponent> Belongings { get; }
    }

    public interface ICard : IComponent, IFlippable
    {

    }

    public interface IToken : IComponent
    {

    }

    public interface IHaveState<TState>
    {
        public TState State { get; }
        public void Change(TState newState);
    }

    public interface IFlippable : IHaveState<FlippableStates>
    {

    }

    public enum FlippableStates : byte
    {
        None = 0,
        Face = 1,
        Back = 2,
    }
}