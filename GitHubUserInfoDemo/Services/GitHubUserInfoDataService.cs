using GitHubUserInfoDemo.Data;
using GitHubUserInfoDemo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace GitHubUserInfoDemo.Services
{
    public class GitHubUserInfoDataService : IGitHubUserInfoDataService
    {
        private readonly GitHubUserInfoEFDataContext _dataContext;
        public GitHubUserInfoDataService(GitHubUserInfoEFDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<GitHubUser> Add(GitHubUser gitHubUser)
        {
            _dataContext.Add(gitHubUser);
            await _dataContext.SaveChangesAsync();
            return gitHubUser;
        }

        public async Task<GitHubUser> Get(string login)
        {
            return await _dataContext.GitHubUsers.Include(t=>t.Repos).FirstOrDefaultAsync(u => u.Login.ToLower() == login.ToLower());

        }

        public async Task Remove(GitHubUser user)
        {
            _dataContext.GitHubUsers.Remove(user);
            await _dataContext.SaveChangesAsync();
        }
    }
}
