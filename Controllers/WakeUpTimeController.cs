using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCTwoToFour.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCTwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WakeUpTimeController : ControllerBase
    {
        private readonly WakeUpTimeServices _wakeUpTimeServices;

        public WakeUpTimeController(WakeUpTimeServices wakeUpTimeServices)
        {
            _wakeUpTimeServices = wakeUpTimeServices;
        }

        [HttpGet]
        [Route("WakeUpTime/{userName}/{wakeTime}")]
        public string WakeUpTime(string userName, int wakeTime)
        {
            return _wakeUpTimeServices.wakeUpTime(userName, wakeTime);
        }

    }
}