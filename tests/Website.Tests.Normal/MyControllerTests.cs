using System.Threading.Tasks;
using Website.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace Website.Tests.Normal
{
	public class MyControllerTests
	{
		[Fact]
		public async Task MyControllerShouldHaveRouteForActionWithId()
		{
			var uri = "/My/Suceed/1";
			var builder = new WebHostBuilder().UseStartup(typeof(Startup));
			using (var client = new TestServer(builder).CreateClient())
			{
				var response = await client.PostAsync(uri, null);
				response.IsSuccessStatusCode.Should().BeTrue(
					because: $"{nameof(MyController)}.{nameof(MyController.Suceed)} should be reachable on '{uri}'.");
			}
		}
	}
}
