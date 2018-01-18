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

using System.Reflection;
using Microsoft.Rest;

namespace Gov.News.Api.ClientTests
{
    public class AzureAsset : ApiTestBase
    {
        /// <summary>
        /// Test GET Azure Asset
        /// </summary>
        [Fact]
        public async void InvalidGet()
        {
            bool foundException = false;
            try
            {
                // get an azure asset.
                var item = await _client.AzureAsset.GetOneAsync(invalidPathKey, currentApiVersion);
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
