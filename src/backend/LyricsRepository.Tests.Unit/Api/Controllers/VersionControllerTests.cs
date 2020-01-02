using System.Threading.Tasks;
using FluentAssertions;
using LyricsRepository.Api;
using LyricsRepository.Api.Controllers;
using LyricsRepository.Core;
using Moq;
using NUnit.Framework;

namespace LyricsRepository.Tests.Unit.Api.Controllers
{
    [TestFixture]
    public class VersionControllerTests : TestBase
    {
        [Test]
        public async Task ShouldReturnVersion()
        {
            const string expected = "1.0.0.0";
            Mock<IVersionService> versionService = Mocker.GetMock<IVersionService>();
            versionService
                .Setup(x => x.GetVersionAsync<Startup>())
                .ReturnsAsync(expected);
            var controller = Mocker.Create<VersionController>();

            var version = await controller.Get();

            versionService.Verify(x => x.GetVersionAsync<Startup>(), Times.Once);
            version.Should().Be(expected);
        }
    }
}