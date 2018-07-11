using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication2;
using Xunit;

namespace WebApplication2Test
{
    public class UnitTest1
    {
        private HttpClient Client { get; set; }
        private TestServer Server { get; set; }

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }
            
        [Fact]
        public async Task ShoulGetOkResponse()
        {
            var response = await Client.GetAsync("/greeter");
            var statusCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.OK, statusCode);
        }
    }
}
