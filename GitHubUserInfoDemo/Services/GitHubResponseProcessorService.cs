using AutoMapper;
using GitHubUserInfoDemo.Data.Models;
using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Services
{
    public class GitHubResponseProcessorService : IGitHubResponseProcessorService
    {
        private readonly IMapper _mapper;
        private readonly IGitHubUserInfoDataService _dataService;

        public GitHubResponseProcessorService(IMapper mapper, IGitHubUserInfoDataService gitHubUserInfoDataService)
        {
            _mapper = mapper;
            _dataService = gitHubUserInfoDataService;
        }

        public async Task<GitHubUserInfoResponse> ProcessData(GitHubUserInfo gitHubUserInfo, IEnumerable<GitHubRepoInfo> gitHubRepoInfo)
        {
            var user = _mapper.Map<GitHubUser>(gitHubUserInfo);
            var repos = _mapper.Map<List<GitHubRepo>>(gitHubRepoInfo);

            foreach (var repo in repos)
            {
                user.Repos!.Add(repo);
            }

            var existingUser = await _dataService.Get(user.Login);
            if (existingUser != null)
            {
                await _dataService.Remove(existingUser);
            }
            
            var response = _mapper.Map<GitHubUserInfoResponse>(await _dataService.Add(user));

            return response;
        }
    }
}
