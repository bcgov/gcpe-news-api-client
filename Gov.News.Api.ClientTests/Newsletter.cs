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
    public class Newsletter : ApiTestBase
    {
        /// <summary>
        /// Test GET Newsletter
        /// </summary>
        [Fact]
        public async void Get()
        {

            // get the article.
            var newsletters = await _client.Newsletter.GetAllAsync(currentApiVersion);

            Assert.True(newsletters != null);
        }
    }
}
