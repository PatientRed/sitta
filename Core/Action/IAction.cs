using Sitta.Core.Rules;

namespace Sitta.Core.Action
{
    public interface IAction
    {
        public string Type { get; }

        public IPropertyContainer Properties { get; }

        public void Perform(IActionHandler actionHandler);
    }

    public interface IStateChange
    {

    }

    public class ModifyTargetAction : IAction
    {
        public string Type => "Modify target.";


        private readonly IPropertyContainer _propertyContainer;
        public IPropertyContainer Properties => _propertyContainer;

        public void Perform(IActionHandler actionHandler)
        {
            actionHandler.HandleModifyTargetAction(this);
        }

        public ModifyTargetAction(IPropertyContainer propertyContainer)
        {
            _propertyContainer = propertyContainer;
        }
    }



    public enum ActionTypes
    {
        Undefined = 0,
        ModifyTarget,

    }
}
