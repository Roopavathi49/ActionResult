using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[]
                { "Hello LTTS!",
                    "Hello Galaxy!",
                    "Hello Universe!"
                };
    }

    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "Hello";
    }

    [HttpPost]
    public string Post([FromBody]string value)
    {
        return "Hello World!";
    }


    [HttpPut("{id}")]
    public string Put(int id, [FromBody]string value)
    {
        return "Hello Galaxy!";
    }


    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return "Hello Universe!";
    }
    }
}
