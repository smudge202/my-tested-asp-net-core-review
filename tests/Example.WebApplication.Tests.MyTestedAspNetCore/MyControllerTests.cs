using Example.WebApplication.Controllers;
using MyTested.AspNetCore.Mvc;
using Xunit;

namespace Example.WebApplication.Tests.MyTestedAspNetCore
{
	public class MyControllerTests
	{
		[Fact]
		public void MyControllerShouldHaveRouteForActionWithId()
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
