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
		public List<ClientFinalOrder> Get()
		{
			return OrderService.activeOrders;
		}

		[HttpPost]
		public List<ClientFinalOrder> Post([FromBody] ClientFinalOrder orders)
		{
			return OrderService.AddActiveOrders();
		}
	}
}
