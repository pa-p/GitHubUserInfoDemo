using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Services
{
    public interface IGitHubService
    {
        Task<GitHubUserInfo> GetUserInfosByOwner(string owner);
        Task<IEnumerable<GitHubRepoInfo>> GetRepoInfosByOwner(string owner);
    }
}
