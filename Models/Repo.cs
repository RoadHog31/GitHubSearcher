using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace GitHubSearcher.Models
{
    public class Repo
    {
        [JsonPropertyName("stargazers_count")]
        public int stargazers_count { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("full_name")]
        public string full_name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }
    }
}