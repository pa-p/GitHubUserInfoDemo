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

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GitHubUserInfo>();
            }

            throw new Exception("Something went wrong");

        }

        public async Task<IEnumerable<GitHubRepoInfo>> GetRepoInfosByLogin(string login)
        {
            var endpoint = $"users/{login}/repos";

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<GitHubRepoInfo>>();
            }

            throw new Exception("Something went wrong");

        }
    }
}
