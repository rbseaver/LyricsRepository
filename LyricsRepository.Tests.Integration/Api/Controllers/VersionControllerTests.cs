using FluentAssertions;
using LyricsRepository.Api;
using LyricsRepository.Tests.Integration.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LyricsRepository.Tests.Integration.Api.Controllers
{
    [TestClass]
    public class VersionControllerTests
    {
        [TestMethod]
        public async Task ShouldGetVersion()
        {
            var expectedVersion = typeof(Startup).Assembly.GetName().Version.ToString();

            using (var client = TestClient.CreateClient())
            {
                var response = await client.GetAsync("/api/version");

                var version = await response.Content.ReadAsStringAsync();

                response.EnsureSuccessStatusCode();
                version.Should().Be(expectedVersion);
            }
        }
    }
}
