using AutoMapper;

namespace AutoMapperTut
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<NflTeam, NflTeamDto>();
            CreateMap<NflTeamDto, NflTeam>();
        }
    }
}
