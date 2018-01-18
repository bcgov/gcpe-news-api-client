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
    public class Story : ApiTestBase
    {
        /// <summary>
        /// Test GET story
        /// </summary>
        [Fact]
        public async void Get()
        {
            // get a story.
            var sectors = await _client.Sector.GetAllAsync(currentApiVersion);
            var sector = sectors[0];
            var id = sector.TopPostId;

            var post = await _client.Post.GetOne2Async(id.Value, currentApiVersion);

            var key = post.Key;
            var item = _client.Story.GetOneAsync(key, currentApiVersion);

            Assert.True(item != null);
        }
    }
}
