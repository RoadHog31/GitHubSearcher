using GitHubSearcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitHubSearcher.ViewModels
{
    public class gitHubDataViewModel
    {

        public User User = new User();
        public List<Repo> Repo = new List<Repo>();
    }
}