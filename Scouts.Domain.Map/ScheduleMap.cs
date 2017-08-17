using Neo4jClient.Extension.Cypher;

namespace Scouts.Domain.Map
{
    public class ScheduleMap 
    {
        public static void Configure()
        {
            var set = FluentConfig.Config()
                .With<Schedule>()
                .Merge(x => x.StartDate)
                .Merge(x => x.EndDate)
                .Set();
        }
    }
}
