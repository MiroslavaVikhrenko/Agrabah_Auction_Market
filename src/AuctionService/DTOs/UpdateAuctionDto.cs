namespace AuctionService.DTOs;

public class UpdateAuctionDto
{
    public string? Origin { get; set; }
    public string? ItemName { get; set; }
    public int? Year { get; set; }
    public string? Material { get; set; }
    public int? ConditionScore { get; set; }
}
