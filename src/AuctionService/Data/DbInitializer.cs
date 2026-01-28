
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<AuctionDbContext>());
    }

    private static void SeedData(AuctionDbContext? context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var auctions = new List<Auction>()
        {
            // auctions
            // 1 Magic Carpet
            new Auction
            {
                Id = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(10),
                Item = new Item
                {
                    Origin = "Agrabah",
                    ItemName = "Magic Carpet",
                    Year = 1020,
                    Material = "Enchanted Silk",
                    ConditionScore = 85,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/3f/Magic_carpet.png"
                }
            },

            // 2 Genie’s Lamp
            new Auction
            {
                Id = Guid.Parse("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"),
                Status = Status.Live,
                ReservePrice = 90000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(60),
                Item = new Item
                {
                    Origin = "Cave of Wonders",
                    ItemName = "Genie's Lamp",
                    Year = 850,
                    Material = "Ancient Brass",
                    ConditionScore = 95,
                    ImageUrl = "https://images.unsplash.com/photo-1667902687222-1b6e158e58ba"
                }
            },

            // 3 Scimitar of the Royal Guard
            new Auction
            {
                Id = Guid.Parse("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"),
                Status = Status.Live,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(4),
                Item = new Item
                {
                    Origin = "Agrabah Palace",
                    ItemName = "Royal Guard Scimitar",
                    Year = 1200,
                    Material = "Forged Steel",
                    ConditionScore = 70,
                    ImageUrl = "https://images.unsplash.com/photo-1667902687222-1b6e158e58ba"
                }
            },

            // 4 Sorcerer’s Hourglass
            new Auction
            {
                Id = Guid.Parse("155225c1-4448-4066-9886-6786536e05ea"),
                Status = Status.ReserveNotMet,
                ReservePrice = 50000,
                Seller = "tom",
                AuctionEnd = DateTime.UtcNow.AddDays(-10),
                Item = new Item
                {
                    Origin = "Desert of Forgotten Sands",
                    ItemName = "Sorcerer’s Hourglass",
                    Year = 600,
                    Material = "Crystal & Gold",
                    ConditionScore = 60,
                    ImageUrl = "https://images.unsplash.com/photo-1501139083538-0139583c060f"
                }
            },

            // 5 Flying Scarab Amulet
            new Auction
            {
                Id = Guid.Parse("466e4744-4dc5-4987-aae0-b621acfc5e39"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(30),
                Item = new Item
                {
                    Origin = "Southern Desert Ruins",
                    ItemName = "Flying Scarab Amulet",
                    Year = 900,
                    Material = "Obsidian & Gold",
                    ConditionScore = 88,
                    ImageUrl = "https://images.unsplash.com/photo-1767786248361-15f2c016f4ff"
                }
            },

            // 6 Staff of Sandstorms
            new Auction
            {
                Id = Guid.Parse("dc1e4071-d19d-459b-b848-b5c3cd3d151f"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(45),
                Item = new Item
                {
                    Origin = "Agrabah Wastelands",
                    ItemName = "Staff of Sandstorms",
                    Year = 700,
                    Material = "Carved Bone & Gemstone",
                    ConditionScore = 75,
                    ImageUrl = "https://images.unsplash.com/photo-1767786248361-15f2c016f4ff"
                }
            },

            // 7 Phoenix Feather Cloak
            new Auction
            {
                Id = Guid.Parse("47111973-d176-4feb-848d-0ea22641c31a"),
                Status = Status.Live,
                ReservePrice = 150000,
                Seller = "alice",
                AuctionEnd = DateTime.UtcNow.AddDays(13),
                Item = new Item
                {
                    Origin = "Volcanic Peaks",
                    ItemName = "Phoenix Feather Cloak",
                    Year = 1100,
                    Material = "Phoenix Feathers",
                    ConditionScore = 92,
                    ImageUrl = "https://images.unsplash.com/photo-1767786248361-15f2c016f4ff"
                }
            },

            // 8 Crystal Ball of Far Sight
            new Auction
            {
                Id = Guid.Parse("6a5011a1-fe1f-47df-9a32-b5346b289391"),
                Status = Status.Live,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(19),
                Item = new Item
                {
                    Origin = "Wizard’s Bazaar",
                    ItemName = "Crystal Ball of Far Sight",
                    Year = 500,
                    Material = "Pure Crystal",
                    ConditionScore = 80,
                    ImageUrl = "https://images.unsplash.com/photo-1767786248361-15f2c016f4ff"
                }
            },

            // 9 Ring of Silent Steps
            new Auction
            {
                Id = Guid.Parse("40490065-dac7-46b6-acc4-df507e0d6570"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "tom",
                AuctionEnd = DateTime.UtcNow.AddDays(20),
                Item = new Item
                {
                    Origin = "Thieves’ Quarter",
                    ItemName = "Ring of Silent Steps",
                    Year = 950,
                    Material = "Shadow Silver",
                    ConditionScore = 78,
                    ImageUrl = "https://images.unsplash.com/photo-1767786248361-15f2c016f4ff"
                }
            },

            // 10 Ancient Map of the Cave of Wonders
            new Auction
            {
                Id = Guid.Parse("3659ac24-29dd-407a-81f5-ecfe6f924b9b"),
                Status = Status.Live,
                ReservePrice = 20000,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(48),
                Item = new Item
                {
                    Origin = "Royal Archives",
                    ItemName = "Map of the Cave of Wonders",
                    Year = 1300,
                    Material = "Aged Parchment",
                    ConditionScore = 65,
                    ImageUrl = "https://images.unsplash.com/photo-1767786248361-15f2c016f4ff"
                }
            }

        };

        context.AddRange(auctions);

        context.SaveChanges();
    }
}
