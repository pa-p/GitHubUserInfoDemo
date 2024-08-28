using AutoMapper;
using GitHubUserInfoDemo.Data.Models;
using GitHubUserInfoDemo.Models;

namespace GitHubUserInfoDemo.Profiles
{
    public class GitHubUserProfile : Profile
    {
        public GitHubUserProfile()
        {
            CreateMap<GitHubUserInfo, GitHubUser>()
                .ForMember(
                dest=>dest.Id, act => act.Ignore() 
                )
                .ForMember(
                dest => dest.GitHubId,
                src => src.MapFrom(x => x.Id));
        }

        
    }
}
