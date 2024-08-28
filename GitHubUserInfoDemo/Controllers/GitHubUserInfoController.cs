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

        public GitHubUserInfoController(IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        [HttpGet("{owner}")]
        [ProducesResponseType(typeof(GitHubUserInfo), StatusCodes.Status200OK)]
        public async Task<ActionResult<GitHubUserInfo>> GetUser([FromRoute] string owner)
        {
            var result = await _gitHubService.GetUserInfosByOwner(owner).ConfigureAwait(false);
            return Ok(result);
        }

        [HttpGet("{owner}/repos")]
        [ProducesResponseType(typeof(GitHubRepoInfo), StatusCodes.Status200OK)]
        public async Task<ActionResult<GitHubRepoInfo>> GetUserRepos([FromRoute] string owner)
        {
            var result = await _gitHubService.GetRepoInfosByOwner(owner).ConfigureAwait(false);
            return Ok(result);
        }
    }
}
