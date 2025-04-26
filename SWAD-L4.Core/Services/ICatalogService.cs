namespace SWAD_L4.Core.Services
{
    public interface ICatalogService
    {
        Task<List<string>> GetAllAttractionsAsync();
        Task<List<string>> GetAllZonesAsync();
        Task<List<string>> GetAllCharactersAsync();
    }
}