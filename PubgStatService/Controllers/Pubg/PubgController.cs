using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pubg.Dto.Pubg;
using Pubg.Service;
using Pubg.Service.Interfaces;

namespace PubgStatService.Controllers.Pubg
{
    public class PubgController : Controller
    {
        public PubgController()
        {
            _statService = new StatService();
        }

        [HttpPost]
        public IActionResult FindStatsForPlayer(FindStatsForPlayerRequest request)
        {
            //TODO: Error handling
            var result = _statService.FindStatsForPlayer(request);

            return new ObjectResult(result);
        }

        #region Private Members

        private readonly IStatService _statService;

        #endregion
    }
}
