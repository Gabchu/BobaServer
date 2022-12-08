using BobaServer.Models;

namespace BobaServer.Services
{
	public static class OrderService
	{
		public static ActiveOrder order;
		public static int LatestOrderID { get; set; }
		public static List<ActiveOrder> Add(List<ActiveOrder> activeorders)
		{
			order.OrderID = ++LatestOrderID;
			activeorders.Add(order);
			return activeorders;
		}
	}
}
