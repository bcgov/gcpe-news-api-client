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
    public class Sectors : ApiTestBase
    {
        /// <summary>
        /// Test GET sectors
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var sectors = await _client.Sectors.GetAllAsync(currentApiVersion);
            var sector = sectors[0];
            Assert.True(sector != null);
        }


        /// <summary>
        /// Test GET sectors
        /// </summary>
        [Fact]
        public async void GetOne()
        {
            var sectors = await _client.Sectors.GetAllAsync(currentApiVersion);
            var sector = sectors[0];

            var second = await _client.Sectors.GetOneAsync(sector.Key, currentApiVersion);
            Assert.True(second != null);

            Assert.Equal(sector.Key, second.Key);
        }

    }
}
