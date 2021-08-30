using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsCoreApp.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobsCoreApp.Controllers
{
    [ApiController]
    public class DayStatisticsController : ControllerBase
    {
        private IDayStatisticsModule _dayStatisticsModule;
        public DayStatisticsController(IDayStatisticsModule dayStatisticsModule)
        {
            _dayStatisticsModule = dayStatisticsModule;
        }

        [HttpGet]
        [Route("api/[controller]/GetDayStatistics")]
        public async Task<IActionResult> GetDayStatistics()
        {

            var daystats = await _dayStatisticsModule.GetDayStatistics();
            return Ok(daystats);
        }
    }
}
