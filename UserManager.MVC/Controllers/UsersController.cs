using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserManager.MVC.Models;

namespace UserManager.MVC.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new List<User>
            {
                new User("Ivan", "Stojanov")
                {
                    Age = 22,
                    Index = 10232,
                },
                new User ("Darko" , "Stojanov")
                {
                    Age=32,
                    Index = 123123,
                },
                new User("Ivan", "Stojanov")
                {
                    Age = 22,
                    Index = 10232,
                },
                new User ("Darko" , "Stojanov")
                {
                    Age=32,
                    Index = 123123,
                },
                new User("Ivan", "Stojanov")
                {
                    Age = 22,
                    Index = 10232,
                },
                new User ("Darko" , "Stojanov")
                {
                    Age=32,
                    Index = 123123,
                }
            };

           
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
