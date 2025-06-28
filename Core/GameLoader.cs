using Sitta.Core.Descriptions;

namespace Sitta.Core
{
    public interface ILoader
    {
        (IEnumerable<ITypeDescription> types, IEnumerable<IObjectDescription> objects) Load();
    }

    internal class GameLoader : ILoader
    {
        private readonly IDataSource _dataSource;

        public (IEnumerable<ITypeDescription> types, IEnumerable<IObjectDescription> objects) Load()
        {
            var content = _dataSource.Load();
            var result = LoadParser().Parse(content);

            throw new NotImplementedException();

            return Process(result);
        }

        private static (IEnumerable<ITypeDescription> types, IEnumerable<IObjectDescription> objects) Process(IEnumerable<IDescription> content)
        {
            throw new NotImplementedException();
        }

        private IParser LoadParser()
        {
            throw new NotImplementedException();
        }

        public GameLoader(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }
    }
}
