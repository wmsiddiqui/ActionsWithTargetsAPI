using ActionWebService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ActionWebService.Controllers
{
    [Route("api/[controller]")]
    public class IncrementDecrementActionController : Controller
    {
        [HttpPost]
        public IncrementDecrementEntity ExecuteIncrementDecrementAction([FromBody] IncrementDecrementEntity target)
        {
            if(target == null)
            {
                return null;
            }
            var IncrementDecrement = new Actions.IncrementDecrementAction(target.IncrementTargets, target.DecrementTargets);
            IncrementDecrement.ExecuteAction();
            return target;
        }

        [HttpGet]
        public string GetAll()
        {
            return "HelloWorld";
        }
    }
}
