﻿//Author: Aaron Miller      
//Purpose: Unit Testing of GET ProductTypes Details

using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BangazonTests
{
    public class ProductTypeDetailsTest : IClassFixture<WebApplicationFactory<Bangazon.Startup>>
    {
        private readonly WebApplicationFactory<Bangazon.Startup> _factory;

        public ProductTypeDetailsTest(WebApplicationFactory<Bangazon.Startup> factory)
        {
            _factory = factory;
        }


        [Theory]
        [InlineData("/")]

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

    }
}
      