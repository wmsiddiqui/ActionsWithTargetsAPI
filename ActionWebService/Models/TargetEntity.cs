using Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActionWebService.Models
{
    public class TargetEntity
    {
        public int Id { get; set; }
        public int Count { get; set; }
    }

    public class IncrementDecrementEntity
    {
        public TargetWithCount[] IncrementTargets { get; set; }
        public TargetWithCount[] DecrementTargets { get; set; }
    }
}
