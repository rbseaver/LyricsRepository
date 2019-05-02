using LyricsRepository.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;

namespace LyricsRepository.Tests.Integration.TestHelper
{
    public class TestClient : IDisposable
    {
        private static TestServer server;
        private static HttpClient client;

        public static HttpClient CreateClient()
        {
            var webHostBuilder = new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>();

            server = new TestServer(webHostBuilder);
            client = server.CreateClient();

            return client;
        }

        public void Dispose()
        {
            server.Dispose();
            client.Dispose();
        }
    }
}
