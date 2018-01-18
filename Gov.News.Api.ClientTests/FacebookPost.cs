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
    public class FacebookPost : ApiTestBase
    {
        /// <summary>
        /// Test GET facebook post
        /// </summary>
        [Fact]
        public async void FacebookPostGetTest()
        {
            var faceBookPost = await _client.FacebookPost.GetNewestAsync(currentApiVersion);
            String key = faceBookPost.Key;

            var second = await _client.FacebookPost.GetByUriAsync(currentApiVersion, key);

            Assert.True(faceBookPost.Poster == second.Poster);
            Assert.True(faceBookPost.PosterUrl == second.PosterUrl);
        }
        

    }
}
