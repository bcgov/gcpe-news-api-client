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
    public class Release : ApiTestBase
    {
        /// <summary>
        /// Test GET search
        /// </summary>
        [Fact]
        public async void Get()
        {
            var newsroom = await _client.Newsroom.GetAsync(currentApiVersion);
            Assert.True(newsroom != null);

            PostCollection releases = newsroom.Releases;
            // PostCollection is currently blank.  No way to get releases out of it.
            var key = "";

            var item = await _client.Release.GetOneAsync(key, currentApiVersion);

            Assert.True(item != null);
        }
    }
}
