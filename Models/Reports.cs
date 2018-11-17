using System;

namespace QuickleeAPI.Models
{
  public class Reports
  {
    public int Id { get; set; }

    public float Sales { get; set; }

    public Inventories BeginInvId { get; set; }
    //using to call Inventory total and date
    public Inventories EndInvId { get; set; }
    //using to call Inventory total and date
  }
}