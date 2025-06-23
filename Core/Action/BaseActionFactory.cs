using Sitta.Core.Descriptions;

namespace Sitta.Core.Action
{
    public static class BaseActionFactory
    {
        public static IAction Create(IActionDescription actiondescription)
        {
            if (actiondescription == null)
                throw new ArgumentNullException(nameof(actiondescription));

            //TODO: this is very naive and seems not optimal
            switch (actiondescription.SystemActionType)
            {
                case var t when t.IsAssignableFrom(typeof(ModifyTargetAction)):
                    return new ModifyTargetAction(new propertyGenerator.Produce(actiondescription));
                //TODO: or?
                //return new ModifyTargetAction(this.ProduceProps(actiondescription));
                default:
                    throw new ArgumentException($"{nameof(actiondescription.SystemActionType)} has unsopported value {actiondescription.SystemActionType}.");
            }
        }
    }
}