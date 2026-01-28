
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public required string Origin { get; set; }
    public required string ItemName { get; set; }
    public int Year { get; set; }
    public required string Material { get; set; }
    public int ConditionScore { get; set; }
    public required string ImageUrl { get; set; }

    // nav prop
    public Auction? Auction { get; set; } = null;
    public Guid AuctionId { get; set; }
}
