using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

namespace GitHubUserInfoDemo.Data.Models
{
    public class GitHubUser
    {
        public long Id { get; set; }
        public string Login { get; set; } = string.Empty;        
        public long GitHubId { get; set; }        
        public string NodeId { get; set; } = string.Empty;        
        public string AvatarUrl { get; set; } = string.Empty;        
        public string GravatarId { get; set; } = string.Empty;        
        public string Url { get; set; } = string.Empty;        
        public string HtmlUrl { get; set; } = string.Empty;        
        public string FollowersUrl { get; set; } = string.Empty;        
        public string FollowingUrl { get; set; } = string.Empty;        
        public string GistsUrl { get; set; } = string.Empty;        
        public string StarredUrl { get; set; } = string.Empty;        
        public string SubscriptionsUrl { get; set; } = string.Empty;        
        public string OrganizationsUrl { get; set; } = string.Empty;       
        public string ReposUrl { get; set; } = string.Empty;        
        public string EventsUrl { get; set; } = string.Empty;        
        public string ReceivedEventsUrl { get; set; } = string.Empty;        
        public string Type { get; set; } = string.Empty;       
        public bool SiteAdmin { get; set; }        
        public string? Name { get; set; }        
        public string? Company { get; set; }        
        public string Blog { get; set; } = string.Empty;        
        public string? Location { get; set; }        
        public string? Email { get; set; }        
        public string? Hireable { get; set; }        
        public string? Bio { get; set; }        
        public string? TwitterUsername { get; set; }       
        public long PublicRepos { get; set; }        
        public long PublicGists { get; set; }        
        public long Followers { get; set; }        
        public long Following { get; set; }        
        public DateTime CreatedAt { get; set; }        
        public DateTime UpdatedAt { get; set; }

        public ICollection<GitHubRepo>? Repos { get; }
    }
}
