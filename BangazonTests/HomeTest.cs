using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BangazonTests
{
 
        //Author: Shu Sajid
        //Purpose: This is a testing unit to check if home page loads

        //This method uses Microsoft.AspNetCore.Mvc.Testing and a refrence to the Bangazon.cproj
        public class HomeTest : IClassFixture<WebApplicationFactory<Bangazon.Startup>>
        {
            private readonly WebApplicationFactory<Bangazon.Startup> _factory;

            public HomeTest(WebApplicationFactory<Bangazon.Startup> factory)
            {
                _factory = factory;
            }
        //This theory only checks one route
        [Theory]
        [InlineData("/")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            //checks header for content that will only be generated on a successful page load
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
        //This fact checks the / route to ensure if the page loads and content is displayed on page
        [Fact]
        public async Task HomeLoads()
        {
            // Arrange
            var _client = _factory.CreateClient();

            //Act
            var response = await _client.GetAsync("/");
            var content = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Matches("&copy; 2018 - Bangazon", content);
            Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
    
}
