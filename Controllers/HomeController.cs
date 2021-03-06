﻿using GitHubSearcher.Models;
using GitHubSearcher.ViewModels;
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
        //Private field
        private static HttpClient HttpClient;        
        

        //Constructor
        public HomeController()
        {
            
            HttpClient = new HttpClient();

        }    

        public ActionResult Index()
        {
            ViewBag.Title = "Main Page";

            return View("Index");
        }


        [HttpGet]
        public async Task<ActionResult> GetAsync(string searchString)
        {
            User UserData = new User();
            List<Repo> RepoData = new List<Repo>();

            string newUrl = "users/" + searchString;

            //*** Start of User api ***
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
                

                //Deserializing the response recieved from web api and storing into the Users list.
                UserData = JsonConvert.DeserializeObject<User>(UserResponse);
                
            }
            
            //*** Start of repo api ***
            var repoUrl = UserData.repos_url;
            string newRepoUrl = repoUrl;

            if (HttpClient.BaseAddress == null)
            {   //Passing service base url
                HttpClient.BaseAddress = new Uri("https://api.github.com/");
            }
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            // You should set the version so that GitHub knows what API you area calling
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            HttpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("product", "1"));

            //Sending request to find web api REST service resource Get all Users using HttpClient.  Set this to the URL you want.
            HttpResponseMessage response2 = await HttpClient.GetAsync(newRepoUrl);


            //Checking the response is successful or not which is sent using HttpClient  
            if (response2.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api   
                var RepoResponse = response2.Content.ReadAsStringAsync().Result;


                //Deserializing the response recieved from web api and storing into the Repo list.
                RepoData = JsonConvert.DeserializeObject<List<Repo>>(RepoResponse);

            }            

            var viewModel = new gitHubDataViewModel
            {
                User = UserData,
                Repo = RepoData
                
            };

            //returning the users list to view via viewmodel object.
            return View("Index", viewModel);            
        }       
    }
}
