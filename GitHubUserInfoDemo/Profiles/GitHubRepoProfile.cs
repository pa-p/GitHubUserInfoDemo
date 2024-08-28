using AutoMapper;
using GitHubUserInfoDemo.Data.Models;
using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Profiles
{
    public class GitHubRepoProfile : Profile
    {
        public GitHubRepoProfile()
        {
            CreateMap<GitHubRepoInfo, GitHubRepo>()
                .ForMember(
                dest => dest.Id, act => act.Ignore()
                )
                .ForMember(
                dest => dest.GitHubId,
                src => src.MapFrom(x => x.Id));
        }
    }
}
