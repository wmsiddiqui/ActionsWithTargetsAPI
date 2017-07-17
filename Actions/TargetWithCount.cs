using System;
using System.Collections.Generic;
using System.Text;

namespace Actions
{
    public class TargetWithCount : Target
    {
        private int _count;
        public TargetWithCount(int id)
            : base(id)
        {
        }

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
    }
}
