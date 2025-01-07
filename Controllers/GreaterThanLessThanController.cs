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
    public class GreaterThanLessThanController : ControllerBase
    {
        private readonly GreaterThanLessThanServices _greaterThanLessThan;
        public GreaterThanLessThanController(GreaterThanLessThanServices anything)
        {
            _greaterThanLessThan = anything;
        }

        [HttpGet]
        [Route("GreaterThanLessThan/{num1}/{num2}")]
        public string GreaterThanLessThan(int num1, int num2)
        {
            return _greaterThanLessThan.GreaterThanLessThan(num1, num2);
        }
    }
}