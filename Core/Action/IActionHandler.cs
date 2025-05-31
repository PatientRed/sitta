namespace Sitta.Core.Action
{
    public interface IActionHandler
    {
        public void HandleModifyTargetAction(IAction action);
        //TODO:
        //public IComponent HandleCreateAction(IComponent subject, IComponentDescription componentDescription);
        //TODO: variant of Modify target?
        //public void HandleDestroyAction(IComponent subject, IComponentDescription componentDescription);
    }
}
