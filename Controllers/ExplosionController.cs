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
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string Explode(string s)
        {
            var result = "";
            for (var i = 0; i < s.Length; i++)
            {
                for (var j = 0; j < Int32.Parse(s[i].ToString()); j++)
                {
                    result += s[i];
                }
            }
            return result;
        }
    }
}