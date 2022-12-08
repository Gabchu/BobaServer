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
		public ActiveOrder Getorder()
		{
			return OrderService.order;
		}

		[HttpPost]

		public List<ActiveOrder> Post(List<ActiveOrder> activeorder)
		{
			return OrderService.Add(activeorder);
		}
	}
}
