using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace GitHubSearcher.Models
{
    public class User
    {       
        public string login { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }
        public string node_id { get; set; }

        [JsonPropertyName("avatar_url")]
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }

        [JsonPropertyName("repos_url")]
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }
        public string company { get; set; }
        public string blog { get; set; }

        [JsonPropertyName("location")]
        public string location { get; set; }
        public object email { get; set; }
        public object hireable { get; set; }
        public string bio { get; set; }
        public object twitter_username { get; set; }
        public int public_repos { get; set; }
        public int public_gists { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}