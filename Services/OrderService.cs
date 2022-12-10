using BobaServer.Controllers;
using BobaServer.Models;

namespace BobaServer.Services
{
	public static class OrderService
	{
		public static Order order { get; set; }
		public static List<Order> orders { get; set; } = new();
		public static List<Order> Add(Order order)
		{
			orders.Add(order);
			return orders;
		}
	}
}
