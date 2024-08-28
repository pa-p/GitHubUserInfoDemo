using System.Text.Json.Serialization;

namespace GitHubUserInfoDemo.Models
{
    public class GitHubRepoInfoResponse
    {
        public long Id { get; set; }        
        public string NodeId { get; set; } = string.Empty;        
        public string Name { get; set; } = string.Empty;        
        public string FullName { get; set; } = string.Empty;        
        public bool PrivateRepo { get; set; }
        
    }
}
