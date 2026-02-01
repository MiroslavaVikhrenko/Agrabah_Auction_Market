using AutoMapper;
using Contracts;
using MassTransit;
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.Consumers;

public class AuctionCreatedConsumer(IMapper mapper) : IConsumer<AuctionCreated>
{
    private readonly IMapper _mapper = mapper;

    public async Task Consume(ConsumeContext<AuctionCreated> context)
    {
        Console.WriteLine("--> Consuming Auction Created: " + context.Message.Id);

        var item = _mapper.Map<Item>(context.Message);

        if (item.Origin == "Foo") throw new ArgumentException("Origin cannot be Foo");

        // save to mongodb
        await item.SaveAsync();
    }
}
