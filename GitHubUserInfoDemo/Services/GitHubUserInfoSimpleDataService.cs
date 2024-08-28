using Dapper;
using GitHubUserInfoDemo.Data;
using GitHubUserInfoDemo.Data.Models;
using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Services
{
    public class GitHubUserInfoSimpleDataService : IGitHubUserInfoSimpleDataService
    {
        private readonly GitHubUserInfoDapperDataContext _dataContext;
        public GitHubUserInfoSimpleDataService(GitHubUserInfoDapperDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<GitHubUserInfoResponse> Get(string login)
        {
            var queryUser = "select u.* from GitHubUsers u where u.login=@Login";
            var queryRepos = $@"select r.* from GitHubRepo r
                                inner join GitHubUsers u on r.GitHubUserId = u.Id
                                where u.login=@Login";
            using (var connection = _dataContext.CreateConnection())
            {
                var user = (await connection.QueryAsync<GitHubUserInfoResponse>(queryUser, new { Login = login })).FirstOrDefault();
                if (user != null)
                {
                    var repos = await connection.QueryAsync<GitHubRepoInfoResponse>(queryRepos, new { Login = login });
                    if (repos.Any())
                    {
                        user.Repos = repos.ToList();
                    }
                }
                return user;
            }
        }
    }
}
