using GitHubUserInfoDemo.Services;
using Microsoft.Net.Http.Headers;

namespace GitHubUserInfoDemo
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddGitHubService(
            this IServiceCollection services,
            Uri baseApiUrl)
        {
            services.AddScoped<IGitHubService, GitHubService>();
            services.AddHttpClient<IGitHubService, GitHubService>(
                client =>
                {
                    client.BaseAddress = baseApiUrl;
                    client.DefaultRequestHeaders.Add(
                        HeaderNames.Accept, "application/vnd.github.v3+json");
                    client.DefaultRequestHeaders.Add(
                        HeaderNames.UserAgent, "HttpRequestsSample");
                });
            return services;
        }
    }
}
