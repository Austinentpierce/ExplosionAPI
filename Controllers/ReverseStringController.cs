using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        public static string Solution(string str)
        {
            var reversedString = "";

            var length = str.Length - 1;

            while (length >= 0)
            {
                reversedString += str[length];
                length--;
            }
            return reversedString;
        }
    }
}