﻿using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UBSI_Ops.server.FunctionalTests;
using FluentAssertions;
using UBSI_Ops.server.Core.Paging;
using UBSI_Ops.server.Customers.Models;
using Xunit;

namespace UBSI_Ops.server.FunctionalTests
{
    public class CustomerApiTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;

        public CustomerApiTest(CustomWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ShouldRetrieveCustomerList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/customer");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var customers = JsonSerializer.Deserialize<PaginatedListTest<CustomerDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            customers.Should().NotBeNull();
        }

        [Fact]
        public async Task ShouldRetrieveSpecificCustomerList()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/customer/Jane");

            // Assert
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var customers = JsonSerializer.Deserialize<PaginatedListTest<CustomerDto>>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            customers.Should().NotBeNull();
        }
    }
}