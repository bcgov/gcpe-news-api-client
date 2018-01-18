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
    public class Slides : ApiTestBase
    {
        /// <summary>
        /// Test GET slides
        /// </summary>
        [Fact]
        public async void GetAll()
        {
            var slides = await _client.Slides.GetAllAsync(currentApiVersion);

            Assert.True(slides != null);            
        }


        /// <summary>
        /// Test GET slide
        /// </summary>
        [Fact]
        public async void GetOne()
        {
            var slides = await _client.Slides.GetAllAsync(currentApiVersion);

            var slide = slides[0];

            var second = await _client.Slides.GetOneAsync(slide.SlideId.ToString(), currentApiVersion);

            Assert.True(slide != null);
            Assert.Equal(slide.Key, second.Key);
        }
    }
}
