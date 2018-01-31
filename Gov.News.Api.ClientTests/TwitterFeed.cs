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
using Microsoft.Rest;

namespace Gov.News.Api.ClientTests
{
    public class TwitterFeed : ApiTestBase
    {
        /// <summary>
        /// Test GET Twitter feed
        /// </summary>
        [Fact]
        public async void Get()
        {
            bool foundException = false;
            try
            {
                // attempt a get using an invalid key.
                var twitterFeed = await _client.TwitterFeed.GetNewestAsync(currentApiVersion);
            }
            catch (HttpOperationException e)
            {
                if (e.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    foundException = true;
                }
            }
            Assert.True(foundException == false); 
        }       
    }
}
