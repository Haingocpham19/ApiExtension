using ApiExtensionAmazon.ModelEx;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiExtension.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public List<Stuff> Get()
        {
            List<Stuff> lstStuffs = new List<Stuff> {
                new Stuff{Id=1,Name="Adidas",Url="adidas.com"},
                new Stuff{Id=2,Name="Rakuten",Url="rakuten.co.jp"},
                new Stuff{Id=3,Name="Nike",Url="nike.com"},
                new Stuff{Id=4,Name="Yahoo! Shopping",Url="shopping.yahoo.co.jp"},
                new Stuff{Id=5,Name="Ebay",Url="ebay.com/"},
                new Stuff{Id=6,Name="Adidas Jp",Url="shop.adidas.jp"},
                new Stuff{Id=7,Name="Adidas",Url="adidas.com"},
                new Stuff{Id=8,Name="Rakuten",Url="rakuten.co.jp"},
                new Stuff{Id=9,Name="Nike",Url="nike.com"},
                new Stuff{Id=10,Name="Yahoo! Shopping",Url="shopping.yahoo.co.jp"},
                new Stuff{Id=11,Name="Ebay",Url="ebay.com/"},
                new Stuff{Id=12,Name="Adidas Jp",Url="shop.adidas.jp"}
            };

            return lstStuffs;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
