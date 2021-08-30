using JobsCoreApp.Model;
using JobsCoreApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsCoreApp.Module
{
    public interface IDayStatisticsModule
    {
        public Task<List<DayStatistics>> GetDayStatistics();
    }
    public class DayStatisticsModule: IDayStatisticsModule
    {
        private IDayStatisticsRepository _dayStatisticsRepository;
        public DayStatisticsModule(IDayStatisticsRepository dayStatisticsRepository)
        {
            _dayStatisticsRepository = dayStatisticsRepository;
        }
        public async Task<List<DayStatistics>> GetDayStatistics()
        {
            List<DayStatistics> dayStatistics = await _dayStatisticsRepository.GetDayStatistics();
            dayStatistics.OrderBy(d => d.DayDate);
            return dayStatistics;
        }
    }
}
