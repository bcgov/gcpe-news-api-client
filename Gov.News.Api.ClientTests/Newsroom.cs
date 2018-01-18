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
    public class Newsroom : ApiTestBase
    {
        /// <summary>
        /// Test GET Newsroom
        /// </summary>
        [Fact]
        public async void GetNewsroom()
        {
            var newsroom = await _client.Newsroom.GetAsync(currentApiVersion);
            Assert.True(newsroom != null);            
        }
    }
}
