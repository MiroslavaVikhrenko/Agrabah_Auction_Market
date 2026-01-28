using MongoDB.Entities;

namespace SearchService.Models;

public class Item : Entity
{
    //public Guid Id { get; set; } => coming from MongoDB.Entities
    public int ReservePrice { get; set; }
    public required string Seller { get; set; }
    public string Winner { get; set; }
    public int SoldAmount { get; set; }
    public int CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime AuctionEnd { get; set; }
    public string Status { get; set; }

    public required string Origin { get; set; }
    public required string ItemName { get; set; }
    public int Year { get; set; }
    public required string Material { get; set; }
    public int ConditionScore { get; set; }
    public required string ImageUrl { get; set; }
}
