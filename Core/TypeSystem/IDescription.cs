namespace Sitta.Core.TypeSystem
{
    public interface IDescription
    {
        public string UserType { get; }
    }

    public interface IParamDescription : IDescription
    {
        public string Name { get; }
        public Type Type { get; }
    }

    public interface IActionDescription : IDescription
    {
        public IEnumerable<IParamDescription> Parameters { get; }
        public Type SystemActionType { get; }
    }

    public interface IComponentDescription : IDescription
    {

    }
}
