namespace Sitta.Core
{
    public interface IDataSource
    {
        public IEnumerable<string> Load();
    }

    public abstract class DataSource : IDataSource
    {
        public IEnumerable<string> Load()
        {
            throw new NotImplementedException();
        }
    }
}
