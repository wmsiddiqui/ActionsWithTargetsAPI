using System;
using System.Collections.Generic;
using System.Text;

namespace Actions
{
    public abstract class Target
    {
        private readonly int _id;
        public int Id
        {
            get { return _id; }
        }
        public Target(int id)
        {
            _id = id;
        }
    }
}
