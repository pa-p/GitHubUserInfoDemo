using GitHubUserInfoDemo.Models;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace GitHubUserInfoDemo.Data.Models
{
    public class GitHubRepo
    {
        public long Id { get; set; }       
        public long GitHubId { get; set; }        
        public string NodeId { get; set; } = string.Empty;        
        public string Name { get; set; } = string.Empty;        
        public string FullName { get; set; } = string.Empty;       
        public bool PrivateRepo { get; set; }        
        public string HtmlUrl { get; set; } = string.Empty;        
        public string Description { get; set; } = string.Empty;        
        public bool Fork { get; set; }        
        public string Url { get; set; } = string.Empty;        
        public string ForksUrl { get; set; } = string.Empty;        
        public string KeysUrl { get; set; } = string.Empty;        
        public string CollaboratorsUrl { get; set; } = string.Empty;        
        public string TeamsUrl { get; set; } = string.Empty;        
        public string HooksUrl { get; set; } = string.Empty;        
        public string IssueEventsUrl { get; set; } = string.Empty;        
        public string EventsUrl { get; set; } = string.Empty;        
        public string AssigneesUrl { get; set; } = string.Empty;        
        public string BranchesUrl { get; set; } = string.Empty;        
        public string TagsUrl { get; set; } = string.Empty;        
        public string BlobsUrl { get; set; } = string.Empty;        
        public string GitTagsUrl { get; set; } = string.Empty;        
        public string GitRefsUrl { get; set; } = string.Empty;        
        public string TreesUrl { get; set; } = string.Empty;        
        public string StatusesUrl { get; set; } = string.Empty;        
        public string LanguagesUrl { get; set; } = string.Empty;        
        public string StargazersUrl { get; set; } = string.Empty;        
        public string ContributorsUrl { get; set; } = string.Empty;        
        public string SubscribersUrl { get; set; } = string.Empty;        
        public string SubscriptionUrl { get; set; } = string.Empty;        
        public string CommitsUrl { get; set; } = string.Empty;        
        public string GitCommitsUrl { get; set; } = string.Empty;        
        public string CommentsUrl { get; set; } = string.Empty;        
        public string IssueCommentUrl { get; set; } = string.Empty; 
        public string ContentsUrl { get; set; } = string.Empty;        
        public string CompareUrl { get; set; } = string.Empty;        
        public string MergesUrl { get; set; } = string.Empty;        
        public string ArchiveUrl { get; set; } = string.Empty;        
        public string DownloadsUrl { get; set; } = string.Empty;        
        public string IssuesUrl { get; set; } = string.Empty;        
        public string PullsUrl { get; set; } = string.Empty;        
        public string MilestonesUrl { get; set; } = string.Empty;        
        public string NotificationsUrl { get; set; } = string.Empty;        
        public string LabelsUrl { get; set; } = string.Empty;        
        public string ReleasesUrl { get; set; } = string.Empty;        
        public string DeploymentsUrl { get; set; } = string.Empty;        
        public DateTime CreatedAt { get; set; }        
        public DateTime UpdatedAt { get; set; }        
        public DateTime PushedAt { get; set; }        
        public string GitUrl { get; set; } = string.Empty;        
        public string SshUrl { get; set; } = string.Empty;        
        public string CloneUrl { get; set; } = string.Empty;        
        public int WatchersCount { get; set; }        
        public string Language { get; set; } = string.Empty;                
        public string Visibility { get; set; } = string.Empty;        
        public long Forks { get; set; }      
        public long Watchers { get; set; }        
        public string DefaultBranch { get; set; } = string.Empty;

        public long GitHubUserId { get; set; }
        public required GitHubUser GitHubUser { get; set; }
    }
}
