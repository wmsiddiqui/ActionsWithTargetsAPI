using System;
using System.Collections.Generic;
using System.Text;

namespace Actions
{
    public class IncrementDecrementAction : Action
    {
        //Don't do this for real. We should specify targets elsewhere. We need to be able to determine the action and its valid targets without specifying targets first
        public IncrementDecrementAction(TargetWithCount[] incrementTargets, TargetWithCount[] decrementTargets) :
            base(null)
        {
            _orderedChildActions = new Action[] { new IncrementAction(incrementTargets), new DecrementAction(decrementTargets) };
        }
    }
}
