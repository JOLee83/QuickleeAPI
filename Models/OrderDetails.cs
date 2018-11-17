using System;

namespace QuickleeAPI.Models
{
  public class OrderDetails
  {
    public int Id { get; set; }

    public float PricePerItem { get; set; }

    public float ItemsReceivedCount { get; set; }

    public Items ItemId { get; set; }

    public Orders OrderId { get; set; }

  }
}