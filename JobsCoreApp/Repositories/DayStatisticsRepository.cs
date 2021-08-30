using JobsCoreApp.DAL;
using JobsCoreApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsCoreApp.Repositories
{
    public interface IDayStatisticsRepository
    {
        public Task<List<DayStatistics>> GetDayStatistics();
    }
    public class DayStatisticsRepository : IDayStatisticsRepository
    {
        private readonly AppDbContext _context;

        public DayStatisticsRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<DayStatistics>> GetDayStatistics()
        {
            return await _context.DaysStatistics.ToListAsync();
        }
    }
}
