using System;
using System.Threading.Tasks;
using PUBGSharp;
using PUBGSharp.Data;
using PUBGSharp.Helpers;
using Pubg.Dto.Pubg;
using Pubg.Service.Interfaces;

namespace Pubg.Service
{
    public class StatService: IStatService
    {
        #region ObjectLifecycle

        public StatService()
        {
            _statsClient = new PUBGStatsClient("api-key-here");
        }

        #endregion

        #region IStatService Implementation

        public async Task<string> FindStatsForPlayer(FindStatsForPlayerRequest request)
        {
            var stats = await _statsClient.GetPlayerStatsAsync(request.PlayerName);

            var kdr = stats.Stats.Find(x => x.Mode == Mode.Duo && x.Region == Region.AGG && x.Season == Seasons.EASeason1).Stats.Find(x => x.Stat == Stats.DamageDealt);
            return kdr.Value;
        }

        #endregion

        #region PrivateMembers

        private readonly PUBGStatsClient _statsClient;

        #endregion
    }


}
