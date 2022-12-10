using BobaServer.Models;
using BobaServer.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BobaServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET: api/<ValuesController>
		[HttpGet]
		public List<ClientFinalOrder> get()
		{
			return OrderService.activeOrders;
		}

		[HttpPost]
		public List<Order> Post(List<Order> orders)
		{
			OrderService.orders.Add(orders);
			return OrderService.orders;
		}
	}
}
