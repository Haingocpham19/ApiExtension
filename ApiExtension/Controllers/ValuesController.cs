using ApiExtension.ModelEx;
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
        List<Stuff> lst = ListStuff.listAll();
        // GET: api/<ValuesController>
        [HttpGet]
        public List<Stuff> Get()
        {
            
            return lst;
        }
        [HttpGet("create")]
        public List<Stuff> Create([FromBody] Stuff stuff)
        {
            List<Stuff> newList = new List<Stuff>();
            foreach (var item in lst)
            {
                newList.Add(item);
            }
            
            Stuff newStuff = new Stuff()
            {
                Id = stuff.Id,
                Name = stuff.Name,
                Url = stuff.Url
            };
            newList.Add(newStuff);
            return newList;
        }
        // Get api/<ValuesController>
        [HttpGet("remove/{id}")]
        public List<Stuff> Remove(int id)
        {
            lst.RemoveAt(id-1);            
            return lst;
        }
        [HttpPut("edit/{id}")]
        public Stuff Edit(int id)
        {
            Stuff newStuff = new Stuff()
            {
                Id = lst[id-1].Id,
                Name = lst[id-1].Name,
                Url = lst[id-1].Url
            };
            return newStuff;
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
