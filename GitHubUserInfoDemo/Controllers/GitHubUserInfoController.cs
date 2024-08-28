using AutoMapper;
using GitHubUserInfoDemo.Data.Models;
using GitHubUserInfoDemo.Models;
using GitHubUserInfoDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitHubUserInfoDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubUserInfoController : ControllerBase
    {
        private readonly IGitHubService _gitHubService;
        private readonly IGitHubResponseProcessorService _gitHubResponseProcessorService;

        public GitHubUserInfoController(IGitHubService gitHubService, IGitHubResponseProcessorService gitHubResponseProcessorService)
        {
            _gitHubService = gitHubService;
            _gitHubResponseProcessorService = gitHubResponseProcessorService;
        }

        [HttpGet("{login}")]
        [ProducesResponseType(typeof(GitHubUserInfoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GitHubUserInfoResponse>> GetUser([FromRoute] string login)
        {
            var user = await _gitHubService.GetUserInfosByLogin(login).ConfigureAwait(false);
            if (!user.Login.Equals(login, StringComparison.InvariantCultureIgnoreCase))
                return NotFound();

            var repos = await _gitHubService.GetRepoInfosByLogin(login).ConfigureAwait(false);
            
            return Ok(await _gitHubResponseProcessorService.ProcessData(user, repos));
        }

        [HttpGet("{login}/repos")]
        [ProducesResponseType(typeof(GitHubRepoInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GitHubRepoInfo>> GetUserRepos([FromRoute] string login)
        {
            var repos = await _gitHubService.GetRepoInfosByLogin(login).ConfigureAwait(false);
            if (!repos.Any())
                return NotFound();

            return Ok(repos);
        }
    }
}
