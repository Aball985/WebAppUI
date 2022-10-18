using AutoMapper;

namespace AustinWebAPI.API.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Models.Domains.Region, Models.DTO.RegionDTO>().ReverseMap();
        }
    }
}
