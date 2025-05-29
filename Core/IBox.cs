using Sitta.Core.Objects;
using Sitta.Core.Rules;

namespace Sitta.Core
{
    public interface IBox
    {
        public IGameplay Gameplay { get; }

        public IEnumerable<IComponent> Components { get; }
    }
}
