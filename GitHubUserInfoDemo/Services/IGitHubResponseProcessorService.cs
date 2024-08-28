using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Services
{
    public interface IGitHubResponseProcessorService
    {
        Task<GitHubUserInfoResponse> ProcessData(GitHubUserInfo gitHubUserInfo, IEnumerable<GitHubRepoInfo> gitHubRepoInfo);
    }
}
