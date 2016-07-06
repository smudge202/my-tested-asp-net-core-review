using System;
using MyTested.AspNetCore.Mvc;
using Website.Controllers;
using Xunit;
using FluentAssertions;
using MyTested.AspNetCore.Mvc.Exceptions;

namespace Website.Tests.MyTestedAsp
{
	public class MyControllerTests
	{
		[Fact]
		public void MyControllerShouldFailToRouteForMismatchedParameter()
		{
			Action runTest = () => MyMvc
				.Routes()
				.ShouldMap(request => request
					.WithMethod(HttpMethod.Post)
					.WithPath("/My/Fail/1"))
				.To<MyController>(c => c.Fail(1));

			runTest.ShouldThrow<RouteAssertionException>()
				.Which.Message.Should().Be("Expected route \'/My/Fail/1\' to contain route value with \'dummy\' key but such was not found.");
		}

		[Fact]
		public void MyControllerShouldSuccessfullyRouteForMatchingParameter()
		{
			MyMvc
				.Routes()
				.ShouldMap(request => request
					.WithMethod(HttpMethod.Post)
					.WithPath("/My/Suceed/1"))
				.To<MyController>(c => c.Suceed(1));
		}
	}
}
