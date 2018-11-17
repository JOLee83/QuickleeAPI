using System;

namespace QuickleeAPI.Models
{
  public class Items
  {
    public int Id { get; set; }

    public string ItemName { get; set; }

    public float ItemPrice { get; set; }
    //will updated through Order Details
    public Users UserId { get; set; }

  }
}