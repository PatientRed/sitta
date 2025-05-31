using Sitta.Core.Objects;
using Sitta.Core.Rules;

namespace Sitta.Core.Action
{
    public class BaseActionHandler : IActionHandler
    {
        protected readonly IBox _game;

        //TODO: why no polymorphism?
        public void HandleModifyTargetAction(IAction action)
        {
            IComponent target = _game.GetCurrentTarget();
            IPropertyContainer actionProps = action.Properties;
            IPropertyContainer gameRules = _game.GetRules(action.Type);
            IPropertyContainer combinedProperties = actionProps.Apply(gameRules);
            IStateChange stateChange = combinedProperties.ProduceStateChange();

            target.Accept(stateChange);
        }
    }
}
