using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace GitHubSearcher.Models
{
    public class User
    {
        
        [JsonPropertyName("name")] 
        public string name { get; set; }

        [Column("Avatar URL")]
        [JsonPropertyName("avatar_url")]
        public string avatar_url { get; set; }
        
        [Column("Repo URL")]
        [JsonPropertyName("repos_url")]
        public string repos_url { get; set; }

        [Column("Location")]
        [JsonPropertyName("location")]
        public string location { get; set; }


    }
}