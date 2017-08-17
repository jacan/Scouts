using System;
using Neo4jClient.Extension.Cypher;
using Neo4jClient;

namespace Scout.Domain.Data
{
    public class NeoRepository
    {
        private readonly MergeOptions _defaultMergeOptions;

        public NeoRepository()
        {
            _defaultMergeOptions = new MergeOptions
            {
                Identifier = "Id",
            };
        }

        public void Add<T>(T domainObject) where T : class
        {
            var label = domainObject.GetType().Name;

            using (var client = new GraphClient(new Uri("http://127.0.0.1:7474/db/data"), "neo4j", "T11spawned"))
            {
                client.Connect();

                var mergeOptions = new MergeOptions
                {
                    Identifier = "Id",
                };

                client.Cypher.CreateEntity(domainObject);
            }
        }
    }
}
