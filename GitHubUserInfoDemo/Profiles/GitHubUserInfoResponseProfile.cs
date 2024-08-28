using AutoMapper;
using GitHubUserInfoDemo.Data.Models;
using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Profiles
{
    public class GitHubUserInfoResponseProfile : Profile
    {
        public GitHubUserInfoResponseProfile()
        {
            CreateMap<GitHubUser, GitHubUserInfoResponse>()
                .ForMember(
                dest => dest.Id,
                src => src.MapFrom(x => x.GitHubId)
                );
        }
    }
}
