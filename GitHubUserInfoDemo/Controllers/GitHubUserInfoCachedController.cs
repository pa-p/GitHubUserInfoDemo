using GitHubUserInfoDemo.Models;
using GitHubUserInfoDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitHubUserInfoDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubUserInfoCachedController : ControllerBase
    {
        private readonly IGitHubUserInfoSimpleDataService _dataService;
        public GitHubUserInfoCachedController(IGitHubUserInfoSimpleDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet("{login}")]
        [ProducesResponseType(typeof(GitHubUserInfoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GitHubUserInfoResponse>> GetUser([FromRoute] string login)
        {
            var user = await _dataService.Get(login);
            if (user == null)
                return NotFound();

            return Ok(user);
        }
    }
}
