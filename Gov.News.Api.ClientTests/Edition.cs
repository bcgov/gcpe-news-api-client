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


namespace Gov.News.Api.ClientTests
{
    public class Edition : ApiTestBase
    {
        /// <summary>
        /// Test GET Edition
        /// </summary>
        [Fact]
        public async void GetAll()
        {            
            // get all editions.
            var item = await _client.Edition.GetAllAsync(currentApiVersion);

            Assert.True(item != null);            
        }        

    }
}
