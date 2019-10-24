using System.Threading.Tasks;
using FluentAssertions;
using LyricsRepository.Api;
using LyricsRepository.Core;
using LyricsRepository.Core.Providers;
using NUnit.Framework;

namespace LyricsRepository.Tests.Unit.Core.Services
{
    [TestFixture]
    public class VersionServiceTests
    {
        [Test]
        public async Task ShouldRetrieveVersion()
        {
            var expected = typeof(Startup).Assembly.GetName().Version.ToString();
            var service = new VersionService(new AssemblyProvider());

            var version = await service.GetVersionAsync<Startup>();

            version.Should().Be(expected);
        }
    }
}