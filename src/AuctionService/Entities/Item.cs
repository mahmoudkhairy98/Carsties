using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

//We added this table attribute to allow EF to create the table in Plural case because if we depend on the relation it will be
//added as Item not Items.
//Note: we will not add Item as DbSet in the context because it is already related to Auction entity and EF will consider it
//automatically as table but it will create in Single case as the class name
[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }

    // nav properties
    public Auction Auction { get; set; }
    public Guid AuctionId { get; set; }
}
