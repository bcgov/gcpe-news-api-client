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


namespace Gov.News.Api.ClientTests
{
    public class Sector : ApiTestBase
    {
        /// <summary>
        /// Test GET sectors
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var sectors = await _client.Sector.GetAllAsync(currentApiVersion);

            Assert.True(sectors != null);
        }
    }
}
