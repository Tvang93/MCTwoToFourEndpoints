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
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;

        public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices)
        {
            _addTwoNumbersServices = addTwoNumbersServices;
        }

        [HttpGet]
        [Route("AddTwoNumbers/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _addTwoNumbersServices.AddTwoNumbers(num1, num2);
        }

    }
}