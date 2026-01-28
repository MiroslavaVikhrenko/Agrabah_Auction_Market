using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public class CreateAuctionDto
{
    [Required]
    public required string Origin { get; set; }
    [Required]
    public required string ItemName { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public required string Material { get; set; }
    [Required]
    public int ConditionScore { get; set; }
    [Required]
    public required string ImageUrl { get; set; }
    [Required]
    public int ReservePrice {get; set;}
    [Required]
    public DateTime AuctionEnd { get; set; }
}
