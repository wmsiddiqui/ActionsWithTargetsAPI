using System;

namespace Actions
{
    public abstract class Action
    {
        protected Target[] _orderedTargets;
        protected Action[] _orderedChildActions;
        protected int _minTargets;
        protected int _maxTargets;

        public Action(Target[] targets)
        {
            _orderedTargets = targets;
        }
        public Target[] GetOrderedTargets()
        {
            return _orderedTargets;
        }
        public virtual bool AreTargetsValid()
        {
            if (GetOrderedTargets() == null && GetMinTargets() > 0)
            {
                return false;
            }
            if (GetOrderedTargets().Length < GetMinTargets())
            {
                return false;
            }
            if (GetOrderedTargets().Length > GetMaxTargets())
            {
                return false;
            }
            return true;
        }
        public int GetMinTargets()
        {
            return _minTargets;
        }
        public int GetMaxTargets()
        {
            return _maxTargets;
        }
        public Action[] GetOrderedChildActions()
        {
            return _orderedChildActions;
        }
        public virtual void ExecuteAction()
        {
            if(GetOrderedChildActions() != null && GetOrderedChildActions().Length > 0)
            {
                foreach(var childAction in GetOrderedChildActions())
                {
                    childAction.ExecuteAction();
                }
            }
        }
    }
}
