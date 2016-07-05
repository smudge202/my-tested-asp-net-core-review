using Example.WebApplication.Controllers;
using MyTested.AspNetCore.Mvc;
using Xunit;

namespace Example.WebApplication.Tests.MyTestedAspNetCore
{
	public class MyControllerTests
	{
		[Fact]
		public void MyControllerShouldHaveRouteForGetActionWithId()
		{
			MyMvc
			.Routes()
			.ShouldMap(request => request
				.WithMethod(HttpMethod.Get)
				.WithPath("/My/Action/1"))
			.To<MyController>(c => c.Action(1));
		}

		[Fact]
		public void MyControllerShouldHaveRouteForPostActionWithId()
		{
			MyMvc
			.Routes()
			.ShouldMap(request => request
				.WithMethod(HttpMethod.Post)
				.WithPath("/My/Action/1"))
			.To<MyController>(c => c.Action(1));
		}
	}
}
