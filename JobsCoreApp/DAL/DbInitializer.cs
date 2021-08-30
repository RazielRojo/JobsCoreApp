using JobsCoreApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsCoreApp.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any DayStatistics.
            if (context.DaysStatistics.Any())
            {
                return;   // DB has been seeded
            }
            List<DayStatistics> DaysStatisticsList = new List<DayStatistics>();
            DateTime baseDate = DateTime.Parse("May 4, 2021");
            for (int i=4; i<29; i++)
            {
                DaysStatisticsList.Add(new DayStatistics { ID=i,ActiveJobs=10+i,JobsViews=10+i*2,PredictedViews= i<25? 10+i*3 : 10+i*3+i*(3^2),DayDate=baseDate });
                baseDate = baseDate.AddDays(1);
            }

            //};
            foreach (DayStatistics d in DaysStatisticsList)
            {
                context.DaysStatistics.Add(d);
            }
            
            context.SaveChanges();
        }
    }
}
