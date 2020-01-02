using System;
using System.Threading.Tasks;
using FluentAssertions;
using LyricsRepository.Api;
using LyricsRepository.Core;
using LyricsRepository.Core.Services;
using Moq;
using NUnit.Framework;

namespace LyricsRepository.Tests.Unit.Core.Services
{
    [TestFixture]
    public class VersionServiceTests : TestBase
    {
        [Test]
        public async Task ShouldRetrieveVersion()
        {
            const string expected = "1.0.0.0";
            var assemblyProvider = Mocker.GetMock<IAssemblyProvider>();
            assemblyProvider.Setup(ap => ap.GetVersion<Startup>())
                .Returns(expected);
            var service = Mocker.Create<VersionService>();

            var version = await service.GetVersionAsync<Startup>();

            Mocker.GetMock<IAssemblyProvider>().Verify(x => x.GetVersion<Startup>(), Times.Once);
            version.Should().Be(expected);
        }
    }
}