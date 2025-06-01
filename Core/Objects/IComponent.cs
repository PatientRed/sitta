using Sitta.Core.Action;
using Sitta.Core.Rules;

namespace Sitta.Core.Objects
{
    public interface IComponent
    {
        public string Name { get; }

        public IEnumerable<IAction> Actions { get; }

        public IPropertyContainer Properties { get; }

        public IEnumerable<IComponent> Belongings { get; }
        public void AcceptChild(IComponent component);
        public void RemoveChild(IComponent component);

        public IComponent Parent { get; }
        public void ChangeParent(IComponent component);
    }

    public interface IBox : IComponent
    {

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