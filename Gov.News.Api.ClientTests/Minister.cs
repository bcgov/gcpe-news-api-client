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
    public class Minister : ApiTestBase
    {
        /// <summary>
        /// Test GET Minister
        /// </summary>
        [Fact]
        public async void InvalidGet()
        {
            bool foundException = false;
            try
            {
                // attempt a get using an invalid key.
                var item = await _client.Minister.GetOneAsync(invalidPathKey, currentApiVersion);
            }
            catch (HttpOperationException e)
            {
                if (e.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    foundException = true;
                }
            }
            Assert.True(foundException);  
        }
    }
}
