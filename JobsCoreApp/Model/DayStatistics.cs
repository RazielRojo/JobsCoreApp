using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;



namespace JobsCoreApp.Model
{

    public class DayStatistics 
    {
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public DateTime DayDate { get; set; }
        public int JobsViews { get; set; }
        public int PredictedViews { get; set; }
        public int ActiveJobs { get; set; }

    }
}
