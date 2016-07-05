using System.Threading.Tasks;
using Example.WebApplication.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace Example.WebApplication.Tests.Conventional
{
	public class MyControllerTests
	{

		[Fact]
		public async Task MyControllerShouldHaveRouteForGetActionWithId()
		{
			var uri = "/My/Action/1";
			var builder = new WebHostBuilder().UseStartup(typeof(Startup));
			using (var client = new TestServer(builder).CreateClient())
			{
				var response = await client.GetAsync(uri);
				response.IsSuccessStatusCode.Should().BeTrue(
					because: $"{nameof(MyController)}.{nameof(MyController.Action)} should be reachable on '{uri}'.");
			}
		}

		[Fact]
		public async Task MyControllerShouldHaveRouteForPostActionWithId()
		{
			var uri = "/My/Action/1";
			var builder = new WebHostBuilder().UseStartup(typeof(Startup));
			using (var client = new TestServer(builder).CreateClient())
			{
				var response = await client.PostAsync(uri, null);
				response.IsSuccessStatusCode.Should().BeTrue(
					because: $"{nameof(MyController)}.{nameof(MyController.Action)} should be reachable on '{uri}'.");
			}
		}
	}
}
