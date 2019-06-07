using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace contact_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly List<Contact> _contacts = new List<Contact>
            {
                new Contact()
                {
                    Id = 1,
                    FirstName = "Conner",
                    LastName = "Bush",
                    Phone = "6063444079",
                    Email = "connerbush@gmail.com",
                    Address = new Address()
                    {
                        Street = "2325 Nashville Pike",
                        City = "Gallatin",
                        State = "TN",
                        Zip = "37066"
                    }
                },
                new Contact()
                {
                    Id = 2,
                    FirstName = "Jon",
                    LastName = "Mayhew",
                    Phone = "5558675309",
                    Email = "jmayhew@str.com",
                    Address = new Address()
                    {
                        Street = "735 E Main St",
                        City = "Hendersonville",
                        State = "TN",
                        Zip = "37075"
                    }
                },
                new Contact()
                {
                    Id = 3,
                    FirstName = "Thomas",
                    LastName = "Bangs",
                    Phone = "5558675309",
                    Email = "tbangs@str.com",
                    Address = new Address()
                    {
                        Street = "735 E Main St",
                        City = "Hendersonville",
                        State = "TN",
                        Zip = "37075"
                    }
                }
            };
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Contact>> Get()
        {
            return _contacts;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
