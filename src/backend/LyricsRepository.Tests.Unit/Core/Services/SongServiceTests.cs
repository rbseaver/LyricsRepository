using Fluency.DataGeneration;
using FluentAssertions;
using LyricsRepository.Core;
using LyricsRepository.Core.Data;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LyricsRepository.Tests.Unit.Core.Services
{
    [TestFixture]
    public class SongServiceTests
    {
        [Test]
        public async Task ShouldGetById()
        {
            const string id = "3C902B27-48C6-4B3D-818C-2DE86035A286";
            var author = $"{ARandom.FirstName()} {ARandom.LastName()}";
            var title = ARandom.Title(20);
            var lyrics = ARandom.String(100);
            var song = new Song
            {
                Id = id,
                Author = author,
                Title = title,
                Lyrics = lyrics
            };
            var repository = new Mock<ISongRepository>();
            repository.Setup(x => x.GetSongById(id)).ReturnsAsync(song);
            var service = new SongService(repository.Object);

            var retrievedSong = await service.GetSongById(id);

            repository.Verify(x => x.GetSongById(id));
            retrievedSong.Should().Be(song);
        }
    }
}
