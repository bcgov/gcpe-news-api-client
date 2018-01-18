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
    public class Tags : ApiTestBase
    {
        /// <summary>
        /// Test GET tags
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var tag = await _client.Tags.GetAllAsync(currentApiVersion);

            Assert.True(tag != null);
        }

        /// <summary>
        /// Test GET tag (one)
        /// </summary>
        [Fact]
        public async void GetOne()
        {
            var tags = await _client.Tags.GetAllAsync(currentApiVersion);
            var tag = tags[0];

            Assert.True(tag != null);

            var second = await _client.Tags.GetOneAsync(tag.Key, currentApiVersion);

            Assert.True(second != null);
            Assert.Equal(tag.Key, second.Key);
        }
    }
}
