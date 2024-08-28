using GitHubUserInfoDemo.Data.Models;

namespace GitHubUserInfoDemo.Services
{
    public interface IGitHubUserInfoDataService
    {
        Task<GitHubUser> Add(GitHubUser gitHubUser);
        Task<GitHubUser> Get(string login);
        Task Remove(GitHubUser user);
    }
}
