using System;
using System.Collections.Generic;
using System.Text;

namespace Actions
{
    public class DecrementAction : Action
    {
        public DecrementAction(Target[] targets)
            : base(targets)
        {
            _minTargets = 0;
            _maxTargets = 1;
        }
        public override bool AreTargetsValid()
        {
            if (!base.AreTargetsValid())
            {
                return false;
            }
            //TODO: Could I use a strategy pattern and use composition instead of inheritance? 
            foreach (var target in GetOrderedTargets())
            {
                if (!(target is TargetWithCount))
                {
                    return false;
                }
            }
            return true;
        }
        public override void ExecuteAction()
        {
            base.ExecuteAction();

            if (!AreTargetsValid())
            {
                throw new Exception("Invalid targets!");
            }
            foreach (var target in GetOrderedTargets())
            {
                var castedTarget = target as TargetWithCount;
                castedTarget.Count--;
            }
        }
    }
}
