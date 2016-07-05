using Microsoft.AspNetCore.Mvc;

namespace Example.WebApplication.Controllers
{
	public class MyController : Controller
	{
		public IActionResult Action(int dummy) => View();
	}
}
