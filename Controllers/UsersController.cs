using GitHubSearcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace GitHubSearcher.Controllers
{
    public class UsersController : ApiController
    {
        /*HttpClient is intended to be instantiated once and re-used throughout the life of an application. Instantiating an HttpClient class for every request will exhaust the number of sockets available under heavy loads. This will result in SocketException errors. Below is an example using HttpClient correctly.The recommended practice is to create a single, shared HttpClient instance throughout the application.*/
        private static readonly HttpClient HttpClient;    
        

        static UsersController()
        {
            //HttpClient is the new and improved way of doing HTTP requests and posts.
            WebRequestHandler handler = new WebRequestHandler()
            {
                UseProxy = true,
            };
            HttpClient = new HttpClient(handler);
            
        }

        public IHttpActionResult GetUsers(string searchString)
        {
            string newurl = "https://api.github.com/users/" + searchString;


            HttpClient.BaseAddress = new Uri("https://api.github.com/users/");

            // You should set the version so that GitHub knows what API you area calling
            HttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            // You must set a user agent so that the CRLF requirement on the header parsing is met.
            // Otherwise you will get an excpetion message with "The server committed a protocol violation. Section=ResponseStatusLine"
            HttpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("Mozilla", "5.0"));

            // Set this to the URL you want.
            var response = HttpClient.GetAsync(newurl).Result;

            return Ok(response);
        }
        

        // GET: api/Users
        public IEnumerable<string> Get()
        {
            yield return "Hi";
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
