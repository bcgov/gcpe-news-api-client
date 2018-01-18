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
    public class Home : ApiTestBase
    {
        /// <summary>
        /// Test GET Home
        /// </summary>
        [Fact]
        public async void GetHome()
        {
            var home = await _client.Home.GetAsync(currentApiVersion);
            Assert.True(home != null);            
        }
    }
}
