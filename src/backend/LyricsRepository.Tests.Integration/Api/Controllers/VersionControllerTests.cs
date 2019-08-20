using FluentAssertions;
using LyricsRepository.Api;
using LyricsRepository.Tests.Integration.TestHelper;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LyricsRepository.Tests.Integration.Api.Controllers
{
    [TestFixture]
    public class VersionControllerTests
    {
        [Test]
        public async Task ShouldGetVersion()
        {
            var expectedVersion = typeof(Startup).Assembly.GetName().Version.ToString();

            using (var client = TestClient.CreateClient())
            using (var response = await client.GetAsync("/api/version"))
            {
                var version = await response.Content.ReadAsStringAsync();

                response.EnsureSuccessStatusCode();

                version.Should().Be(expectedVersion);
            }
        }
    }
}