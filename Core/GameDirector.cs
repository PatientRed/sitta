using Sitta.Core.Descriptions;

namespace Sitta.Core
{
    internal class GameDirector
    {
        private IEnumerable<IDescription> _types;

        private IDataSource GetDataSource()
        {
            throw new NotImplementedException();
        }

        private void InitializeTypes()
        {
            IEnumerable<IObjectDescription> objects;
            (_types, objects) = new GameLoader(GetDataSource()).Load();

            throw new NotImplementedException();
        }
    }
}
