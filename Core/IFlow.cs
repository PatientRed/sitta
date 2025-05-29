namespace Sitta.Core
{
    public interface IFlow
    {
        public IEnumerable<IStep> Steps { get; }

        public IStep CurrentStep { get; }
    }

    public interface IStep
    {
        string Name { get; }
    }
}
