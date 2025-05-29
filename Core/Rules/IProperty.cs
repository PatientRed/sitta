namespace Sitta.Core.Rules
{
    public interface IProperty
    {
        bool IsValidFor(IState state);
    }

    public class Property : IProperty
    {

    }

    public interface IPropertyContainer
    {
        public IEnumerable<IProperty> GetProperties();

        public bool HaveProperty() => throw new NotImplementedException("Add argument.");
    }

    public class Properties : IPropertyContainer
    {
        private readonly IEnumerable<IProperty> _properties;

        public Properties(int size)
        {
            _properties = new List<IProperty>(size);
        }

        public Properties(IEnumerable<IProperty> properties)
        {
            _properties = [.. properties];
        }

        public Properties() { }
    }
}
