using System;

namespace Scouts.Domain
{
    public class Schedule
    {
        public Schedule(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate.Date;
            EndDate = endDate.Date;
        }

        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
    }
}
