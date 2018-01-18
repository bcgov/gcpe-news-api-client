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
using Gov.News.Api.Models;

namespace Gov.News.Api.ClientTests
{
    public class Service : ApiTestBase
    {
        /// <summary>
        /// Test GET services
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var services = await _client.Service.GetAllAsync(currentApiVersion);
            var service = services[0];
            Assert.True(service != null);
        }

        /// <summary>
        /// Test GET from post reference.
        /// </summary>
        [Fact]
        public async void GetFromPostReference()
        {
            var post = await _client.Post.GetFeaturePostAsync(currentApiVersion);
            string reference = post.Reference;
            var service = await _client.Service.GetFromPostReferenceAsync(currentApiVersion, reference);
            Assert.True(service != null);
        }

        /// <summary>
        /// Test GET from invalid post reference.
        /// </summary>
        [Fact]
        public async void GetFromInvalidPostReference()
        {
            var post = await _client.Post.GetFeaturePostAsync(currentApiVersion);
            string reference = post.Reference;
            var service = await _client.Service.GetFromPostReferenceAsync(currentApiVersion, reference);
            Assert.True(service != null);
        }
    }
}
