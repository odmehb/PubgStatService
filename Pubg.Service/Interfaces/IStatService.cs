using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pubg.Dto.Pubg;

namespace Pubg.Service.Interfaces
{
    public interface IStatService
    {
        Task<string> FindStatsForPlayer(FindStatsForPlayerRequest request);
    }
}
