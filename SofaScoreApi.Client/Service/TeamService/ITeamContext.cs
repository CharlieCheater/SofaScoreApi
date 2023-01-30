using SofaScoreApi.DAL.Models;

namespace SofaScoreApi.Client.Service.TeamService;

public interface ITeamContext
{
    Task<IEnumerable<SportEvent>> GetLastEvents(int teamId);
    Task<IEnumerable<SportEvent>> GetNextEvents(int teamId);
}
