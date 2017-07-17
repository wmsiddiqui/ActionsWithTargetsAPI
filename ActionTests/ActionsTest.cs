using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Actions;

namespace ActionTests
{
    [TestClass]
    public class ActionsTest
    {
        [TestMethod]
        public void ProperTargets()
        {
            var incrementTarget1 = new TargetWithCount(1)
            {
                Count = 3
            };

            var incrementTarget2 = new TargetWithCount(2)
            {
                Count = 1
            };

            var decrementTarget = new TargetWithCount(3)
            {
                Count = 10
            };


            var incrementTargets = new TargetWithCount[] { incrementTarget1, incrementTarget2 };
            var decrementTargets = new TargetWithCount[] { decrementTarget };

            var incrementDecrement = new Actions.IncrementDecrementAction(incrementTargets, decrementTargets);
            incrementDecrement.ExecuteAction();

            Assert.AreEqual(4, incrementTarget1.Count);
            Assert.AreEqual(2, incrementTarget2.Count);
            Assert.AreEqual(9, decrementTarget.Count);
        }

        [TestMethod]
        
        [ExpectedException(typeof(Exception))]
        public void ImproperTargets()
        {
            var incrementTarget1 = new TargetWithCount(1)
            {
                Count = 3
            };

            var incrementTarget2 = new TargetWithCount(2)
            {
                Count = 1
            };

            var decrementTarget = new TargetWithCount(3)
            {
                Count = 10
            };


            var incrementTargets = new TargetWithCount[] { };
            var decrementTargets = new TargetWithCount[] { decrementTarget };

            var incrementDecrement = new Actions.IncrementDecrementAction(incrementTargets, decrementTargets);
            incrementDecrement.ExecuteAction();
        }
    }
}
