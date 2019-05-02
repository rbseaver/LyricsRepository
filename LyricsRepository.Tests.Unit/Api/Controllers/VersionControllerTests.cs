using FluentAssertions;
using LyricsRepository.Api;
using LyricsRepository.Api.Controllers;
using LyricsRepository.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace LyricsRepository.Tests.Unit.Api.Controllers
{
    [TestClass]
    public class VersionControllerTests
    {
        [TestMethod]
        public async Task ShouldReturnVersion()
        {
            var versionService = new Mock<IVersionService>();
            versionService.Setup(x => x.GetVersionAsync<Startup>()).ReturnsAsync("1.0.0.0");
            var controller = new VersionController(versionService.Object);

            var version = await controller.Get();

            version.Should().Be("1.0.0.0");
        }
    }
}
