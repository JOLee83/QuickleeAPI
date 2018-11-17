using System;

namespace QuickleeAPI.Models
{
  public class Inventories
  {
    public int Id { get; set; }

    public float InventoryTotal { get; set; }
    //will be calculated form Inventory Details
    public string InventoryDate { get; set; }

    public Users UserId { get; set; }
  }
}