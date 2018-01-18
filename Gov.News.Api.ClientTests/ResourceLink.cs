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
    public class ResourceLink : ApiTestBase
    {
        /// <summary>
        /// Test GET search
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var links = await _client.ResourceLink.GetAllAsync(currentApiVersion);
            Assert.True(links != null);
        }        
    }
}
