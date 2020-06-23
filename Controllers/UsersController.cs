using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace GitHubSearcher.Controllers
{
    public class UsersController : ApiController
    {
        /*HttpClient is intended to be instantiated once and re-used throughout the life of an application. Instantiating an HttpClient class for every request will exhaust the number of sockets available under heavy loads. This will result in SocketException errors. Below is an example using HttpClient correctly.The recommended practice is to create a single, shared HttpClient instance throughout the application.*/
        private static readonly HttpClient HttpClient;

        public string SearchString { get; set; }

        static UsersController()
        {
            //HttpClient is the new and improved way of doing HTTP requests and posts.
            HttpClient = new HttpClient();
        }

        public ActionResult View()
        {
            

            return View();
        }

        // GET: api/Users
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
