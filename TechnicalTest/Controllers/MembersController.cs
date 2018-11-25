using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnicalTest.Models;

namespace TechnicalTest.Controllers
{
    public class MembersController : ApiController
    {
        List<Member> members = new List<Member>();
        

        public MembersController()
        {
            List<Products> first = new List<Products>();
            first.Add(new Products { name = "Healthcare", cost = 100 });
            first.Add(new Products { name = "Travel Insurance", cost = 150 });

            List<Products> second = new List<Products>();
            second.Add(new Products { name = "Healthcare", cost = 100 });
            second.Add(new Products { name = "Travel Insurance", cost = 150 });
            second.Add(new Products { name = "Car Insurance", cost = 300 });
            
            List<Products> third = new List<Products>();
             third.Add(new Products { name = "Travel Insurance", cost = 200 });

            members.Add(new Member { memberNumber = 1234567890, forename = "Fred", surname = "Smith", products = first });
            members.Add(new Member { memberNumber = 1, forename = "Big", surname = "Ben", products = second});
            members.Add(new Member { memberNumber = 2, forename = "Jack", surname = "Ryan", products = third });   
        }
        // GET: api/Members
        public List<Member> Get()
        {
            return members;
        }

        // GET: api/Members/5
        public Member Get(int id)
        {
            return members.Where(x => x.memberNumber == id).FirstOrDefault();
        }

        // POST: api/Members
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Members/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Members/5
        public void Delete(int id)
        {
        }
    }
}
