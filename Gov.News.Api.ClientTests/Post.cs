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
    public class Post : ApiTestBase
    {
        /// <summary>
        /// Test GET Post
        /// </summary>
        [Fact]
        public async Task Get()
        {
            var post = await _client.Post.GetFeaturePostAsync(currentApiVersion);
            String key = post.Key;
        
            var second = await _client.Post.GetOne1Async(post.Collection, post.Key, currentApiVersion);

            Assert.True(post.Summary == second.Summary);
        }       
    }
}
