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

        public async Task<GitHubUserInfo> GetUserInfosByLogin(string login)
        {
            var endpoint = $"users/{login}";
            var user = new GitHubUserInfo();
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            if(response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadFromJsonAsync<GitHubUserInfo>();
            }
            
            return user;

        }

        public async Task<IEnumerable<GitHubRepoInfo>> GetRepoInfosByLogin(string login)
        {
            var endpoint = $"users/{login}/repos";
            var repos = new List<GitHubRepoInfo>();

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                repos = await response.Content.ReadFromJsonAsync<List<GitHubRepoInfo>>();
            }

            return repos;

        }
    }
}
