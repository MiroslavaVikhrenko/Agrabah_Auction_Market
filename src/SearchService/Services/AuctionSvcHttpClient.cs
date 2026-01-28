using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.Services;

// example of synchronous messaging between auction and search services (not best practice, distributed monolith)
public class AuctionSvcHttpClient(HttpClient httpClient, IConfiguration config)
{
    private readonly IConfiguration _config = config;
    private readonly HttpClient _httpClient = httpClient;

    public async Task<List<Item>> GetItemsForSearchDb()
    {
        var lastUpdated = await DB.Find<Item, string>()
            .Sort(x => x.Descending(x => x.UpdatedAt))
            .Project(x => x.UpdatedAt.ToString())
            .ExecuteFirstAsync();

        // GetFromJsonAsync => automatically deserializes what gets from auction service to list of items
        return await _httpClient.GetFromJsonAsync<List<Item>>(_config["AuctionServiceUrl"] + "/api/auctions?date=" + lastUpdated);
    }
}
