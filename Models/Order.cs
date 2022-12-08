using Microsoft.AspNetCore.SignalR;

namespace BobaServer.Models
{
	public class Order
	{
		public string? ProductName { get; set; }
		public int Count { get; set; }
	}
	public class ActiveOrder
	{
		public List<Order> activeorders { get; set; } = new();
		public int OrderID { get; set; }
	}
}
