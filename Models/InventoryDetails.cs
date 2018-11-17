using System;

namespace QuickleeAPI.Models
{
  public class InventoryDetails
  {
    public int Id { get; set; }

    public Items ItemId { get; set; }

    public float ItemOnHandCount { get; set; }

    public Inventories InventoryId { get; set; }

  }
}
