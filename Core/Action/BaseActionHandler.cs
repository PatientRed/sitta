using Sitta.Core.Objects;

namespace Sitta.Core.Action
{
    public class BaseActionHandler : IActionHandler
    {
        protected readonly IBox _game;

        public void HandleModifyTargetAction(IAction action)
        {
            var target = _game.GetCurrentTarget();
            var actionProps = action.Properties;
            var gameRules = _game.GetRules(action.Type);
            var combinedProperties = actionProps.Apply(gameRules);
            var stateChange = combinedProperties.ProduceStateChange();

            target.Accept(stateChange);
        }
    }
}
