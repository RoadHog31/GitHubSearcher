using GitHubSearcher.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GitHubSearcher.Controllers
{
    public class HomeController : Controller
    {
        /*Private field: HttpClient is intended to be instantiated once and re-used throughout the life of an application. Instantiating an HttpClient class for every request will exhaust the number of sockets available under heavy loads. This will result in SocketException errors. Below is an example using HttpClient correctly.The recommended practice is to create a single, shared HttpClient instance throughout the application.*/
        private static HttpClient HttpClient;        

        public List<User> UserData { get; private set; }

        //Constructor
        public HomeController()
        {
            
            HttpClient = new HttpClient();

        }    

        public ActionResult Index()
        {
            return View("Index");
        }


        /*Steps involved:
            1) Get Json URL which will provide Github user data
            2) Generate the C# Mapper class for the Json result data or Json response.
            3) Deserialize Json result to C# mapper class.
            4) Pass this mapped data to view
            5) Display this Json result data to user in a Razor view page.
        */
        [HttpGet]
        public async Task<ActionResult> GetAsync(string searchString)
        {
            
            
            string newUrl = "users/" + searchString;
            
                        
            if (HttpClient.BaseAddress == null)
            {   //Passing service base url
                HttpClient.BaseAddress = new Uri("https://api.github.com/");
            }
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            // You should set the version so that GitHub knows what API you area calling
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            HttpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("product", "1"));

            //Sending request to find web api REST service resource Get all Users using HttpClient.  Set this to the URL you want.
            HttpResponseMessage response = await HttpClient.GetAsync(newUrl);


            //Checking the response is successful or not which is sent using HttpClient  
            if (response.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api   
                var UserResponse = response.Content.ReadAsStringAsync().Result;

                //Deserializing the response recieved from web api and storing into the Employee list  
                UserData = JsonConvert.DeserializeObject<List<User>>(UserResponse);

            }

            //returning the users list to view  
            return View("Index", UserData);
            
        }

        
    }
}
