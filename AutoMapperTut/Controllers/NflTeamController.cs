using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperTut.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NflTeamController : ControllerBase
    {
        private static List<NflTeam> teams = new List<NflTeam>
        {
            new NflTeam
            {
                Id = 1,
                Name = "Chiefs",
                City = "Kansas city",
                StarPlayer = "Patrick Mahomes",
                SuperBowls = 2,
                Founded = new DateTime(1960, 1, 1),
                Modified = null
            },
            new NflTeam
            {
                Id = 2,
                Name = "Saints",
                City = "New Orleans",
                StarPlayer = "Alvin Kamara",
                SuperBowls = 1,
                Founded = new DateTime(1967, 1, 1),
                Modified = null
            },
        };

        private readonly IMapper _mapper;

        public NflTeamController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<NflTeam>> GetTeams()
        {
            return Ok(teams.Select(team => _mapper.Map<NflTeamDto>(team)));
        }
        [HttpPost]
        public ActionResult<List<NflTeam>> AddTeam(NflTeamDto newTeam)
        {
            var team = _mapper.Map<NflTeam>(newTeam);
            teams.Add(team);

            return Ok(teams.Select(team => _mapper.Map<NflTeamDto>(team)));
        }
    }
}
