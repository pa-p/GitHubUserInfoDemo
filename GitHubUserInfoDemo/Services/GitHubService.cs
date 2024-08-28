using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Services
{
    public class GitHubService : IGitHubService
    {
        private readonly HttpClient _httpClient;

        public GitHubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GitHubUserInfo> GetUserInfosByOwner(string owner)
        {
            var endpoint = $"users/{owner}";

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GitHubUserInfo>();
            }

            throw new Exception("Something went wrong");

        }

        public async Task<IEnumerable<GitHubRepoInfo>> GetRepoInfosByOwner(string owner)
        {
            var endpoint = $"users/{owner}/repos";

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<GitHubRepoInfo>>();
            }

            throw new Exception("Something went wrong");

        }
    }
}
