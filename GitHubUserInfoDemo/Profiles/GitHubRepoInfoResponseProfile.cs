using AutoMapper;
using GitHubUserInfoDemo.Data.Models;
using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Profiles
{
    public class GitHubRepoInfoResponseProfile : Profile
    {
        public GitHubRepoInfoResponseProfile()
        {
            CreateMap<GitHubRepo, GitHubRepoInfoResponse>()
                .ForMember(
                dest => dest.Id, 
                src => src.MapFrom(x => x.GitHubId)
                );
        }
    }
}
