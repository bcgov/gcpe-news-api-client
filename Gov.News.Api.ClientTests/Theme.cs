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
    public class Theme : ApiTestBase
    {
        /// <summary>
        /// Test GET themes
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var themes = await _client.Themes.GetAllAsync(currentApiVersion);
            Assert.True(themes != null);
        }

        /// <summary>
        /// Test GET themes
        /// </summary>
        [Fact]
        public async void GetOne()
        {
            var themes = await _client.Themes.GetAllAsync(currentApiVersion);
            Assert.True(themes != null);

            var theme = themes[0];
            Assert.True(theme != null);

            var second = await _client.Themes.GetOneAsync(theme.Key, currentApiVersion);

            Assert.True(second != null);
            Assert.Equal(second.Key, theme.Key);
        }
    }
}
