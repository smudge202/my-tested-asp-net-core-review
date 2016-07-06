using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
	public class MyController
	{
		public IActionResult Fail(int dummy) => null;

		public IActionResult Suceed(int id) => null;
	}
}
