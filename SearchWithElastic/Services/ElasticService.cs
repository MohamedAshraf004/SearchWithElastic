
using Microsoft.Extensions.Options;
using SearchWithElastic.Models;

namespace SearchWithElastic.Services
{
    public class ElasticService : IElasticService
    {
        private readonly ElasticSettings _elasticSettings;
        private readonly ElasticSearchClient _client;


        public ElasticService(IOptions<ElasticSettings> options)
        {
            _elasticSettings = options.Value;
        }
        public Task CreateIndexIfNotExsitsAsync(string indexName)
        {
            throw new NotImplementedException();
        }
    }
}
