using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace GitHubSearcher.Models
{
    public class Repo
    {
        [Column("Name")]
        [JsonPropertyName("name")]
        public string name { get; set; }        

        [Column("StarGazer Count")]
        [JsonPropertyName("stargazers_count")]
        public int stargazers_count { get; set; }

        [Column("Full Name")]
        [JsonPropertyName("full_name")]
        public string full_name { get; set; }

        [Column("Description")]
        [JsonPropertyName("description")]
        public string description { get; set; }

        [Column("html url")]
        [JsonPropertyName("description")]
        public string html_url { get; set; }

    }
}