namespace SearchWithElastic.Services
{
    public interface IElasticService
    {
        Task CreateIndexIfNotExsitsAsync(string indexName);
    }
}
