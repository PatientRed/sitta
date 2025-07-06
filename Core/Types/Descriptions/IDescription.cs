namespace Sitta.Core.Types.Descriptions
{
    public interface IDescription
    {
        public string UserType { get; }
    }

    public interface ITypeDescription : IDescription
    {

    }

    //TODO: replace system type fields type with respective enums?
    //No reflection supposed yet, so no real necessity in having Type variable.
    //Moreover types can't be switched naturally (switches on type variable are clumsy).
    public interface IParamDescription : ITypeDescription
    {
        public string Name { get; }
        public SimpleType SystemParamType { get; }
    }

    public interface IActionDescription : ITypeDescription
    {
        public IEnumerable<IParamDescription> Parameters { get; }
        public Type SystemActionType { get; }
    }

    public interface IComponentDescription : ITypeDescription
    {

    }

    public interface IObjectDescription : IDescription
    {

    }
}
