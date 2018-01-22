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
    public class CalendarTest : ApiTestBase
    {
        /*  Calendar does not seem to be implemented right now...likely this test will be removed.
        /// <summary>
        /// Test GET Calendar
        /// </summary>
        [Fact]
        public async Task Get()
        {
            // get a calendar
            string key = "https://www.google.com/calendar/ical/441bcoaa32buk3r78s0j3o4gqk%40group.calendar.google.com/public/basic.ics";
            // replace slashes with dashes.
            //key = key.Replace('/', '-');

            var item = await _client.Calendar.GetOneAsync(key, currentApiVersion);

            Assert.True(item != null);

        }


        /// <summary>
        /// Test GET Calendar
        /// </summary>
        [Fact]
        public async Task InvalidGet()
        {
            bool foundException = false;
            try
            {
                // attempt a get using an invalid key
                var item = await _client.Calendar.GetOneAsync(invalidPathKey, currentApiVersion);
            Assert.True(item == null);
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

    */
    }
}
