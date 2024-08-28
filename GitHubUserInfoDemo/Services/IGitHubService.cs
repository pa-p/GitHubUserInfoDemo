using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Services
{
    public interface IGitHubService
    {
        Task<GitHubUserInfo> GetUserInfosByLogin(string login);
        Task<IEnumerable<GitHubRepoInfo>> GetRepoInfosByLogin(string login);
    }
}
