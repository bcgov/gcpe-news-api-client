using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using Gov.News.Api.Models;

namespace Gov.News.Api.ClientTests
{
    public class Services : ApiTestBase
    {
        /// <summary>
        /// Test GET services
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var services = await _client.Services.GetAllAsync(currentApiVersion);
            var service = services[0];
            Assert.True(service != null);
        }

        /// <summary>
        /// Test GET services
        /// </summary>
        [Fact]
        public async void GetOne()
        {
            var services = await _client.Services.GetAllAsync(currentApiVersion);
            var service = services[0];

            var second = await _client.Services.GetOneAsync(service.Key, currentApiVersion);

            Assert.True(second != null);

            Assert.Equal(service.Key, second.Key);
        }


    }
}
