using BobaServer.Controllers;
using BobaServer.Models;

namespace BobaServer.Services
{
	public static class OrderService
	{
		public static List<ClientFinalOrder> activeOrders = new();
		public static ClientFinalOrder ClientFinalOrder { get; set; }
		public static List<ClientFinalOrder> AddActiveOrders()
		{
			activeOrders.Add(ClientFinalOrder);
			return activeOrders;
		}
	}
}
