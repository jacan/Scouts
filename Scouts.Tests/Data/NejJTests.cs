using Scout.Domain.Data;
using Scouts.Domain;
using Scouts.Domain.Map;
using System;
using Xunit;

namespace Scouts.Tests
{
    public class NeoJTests
    {
        public NeoJTests()
        {
            ScheduleMap.Configure();
        }

        [Fact]
        public void CanMergeEntity()
        {
            //var prod = new ProductionCompany(
            //    DomainFactory.CreateId(),
            //    DomainFactory.CreateId(),
            //    "20'th Century Fox",
            //    new Schedule(DateTime.Now, DateTime.Now.AddMonths(2)),
            //    new Address(new[] { "Street 1" }, new CanadianPostalCode()),
            //    new ContactInformation("example@example.org", "12356789")

            //    );

            var schedule = new Schedule(DateTime.Now, DateTime.Now.AddMonths(2));
            
            var sut = new NeoRepository();

            sut.Add(schedule);
        }
    }
}
