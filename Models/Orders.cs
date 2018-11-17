using System;

namespace QuickleeAPI.Models
{
  public class Orders
  {
    public int Id { get; set; }

    public string Vendor { get; set; }

    public float OrderTotal { get; set; }
    //will be calculated from Order details
    public string OrderDate { get; set; }
    public Users UserId { get; set; }
  }
}