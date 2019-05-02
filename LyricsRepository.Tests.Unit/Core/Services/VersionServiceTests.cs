using FluentAssertions;
using LyricsRepository.Api;
using LyricsRepository.Core;
using LyricsRepository.Core.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LyricsRepository.Tests.Unit.Core.Services
{
    [TestClass]
    public class VersionServiceTests
    {
        [TestMethod]
        public async Task ShouldRetrieveVersion()
        {
            var expected = typeof(Startup).Assembly.GetName().Version.ToString();
            var service = new VersionService(new AssemblyProvider());

            var version = await service.GetVersionAsync<Startup>();

            version.Should().Be(expected);
        }
    }
}
