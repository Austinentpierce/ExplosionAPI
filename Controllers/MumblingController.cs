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
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public static String Accumulate(string s)
        {
            var result = "";

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        var capitalizedChar = Char.ToUpper(s[i]);
                        result += capitalizedChar;
                    }
                    else
                    {
                        result += Char.ToLower(s[i]);
                    }
                }
                if (i != s.Length - 1)
                {
                    result += '-';
                }
            }
            return result;
        }
    }
}