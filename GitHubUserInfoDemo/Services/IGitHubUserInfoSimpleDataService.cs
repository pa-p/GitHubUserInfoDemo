using GitHubUserInfoDemo.Data.Models;
using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Services
{
    public interface IGitHubUserInfoSimpleDataService
    {
        Task<GitHubUserInfoResponse> Get(string login);
    }
}
