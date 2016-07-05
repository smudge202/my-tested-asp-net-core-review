using Microsoft.AspNetCore.Mvc;

namespace Example.WebApplication.Controllers
{
	public class MyController : Controller
	{
		[HttpPost]
		public IActionResult Action(int dummy) => Json("Hello World!");
	}
}
