﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BangazonTests
{
	/*
	class ProductDetailTest
	{
	}
	*/

	public class ProductDetailTest : IClassFixture<WebApplicationFactory<Bangazon.Startup>>
	{
		private readonly WebApplicationFactory<Bangazon.Startup> _factory;

		public ProductDetailTest(WebApplicationFactory<Bangazon.Startup> factory)
		{
			_factory = factory;
		}

		[Theory]
		[InlineData("/Products/Details/1")]
		public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
		{
			// Arrange
			var client = _factory.CreateClient();

			// Act
			var response = await client.GetAsync(url);

			// Assert
			response.EnsureSuccessStatusCode(); // Status Code 200-299
			Assert.Equal("text/html; charset=utf-8",
				response.Content.Headers.ContentType.ToString());
		}

		/*
		[Fact]
		public async Task Post_DeleteAllMessagesHandler_ReturnsRedirectToRoot()
		{
			// Arrange
			var _client = _factory.CreateClient();

			//Act
			var response = await _client.GetAsync("/");
			var content = await response.Content.ReadAsStringAsync();

			// Assert
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
			Assert.Matches("&copy; 2017 - Bangazon", content);
			Assert.Equal("text/html; charset=utf-8",
				response.Content.Headers.ContentType.ToString());
		}
		*/
	}
}
