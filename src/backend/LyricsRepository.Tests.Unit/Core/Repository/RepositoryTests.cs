using FluentAssertions;
using LyricsRepository.Core;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LyricsRepository.Tests.Unit.Core.Repository
{
    [TestFixture]
    public class RepositoryTests
    {
        private FakeSongRepository repository;

        [SetUp]
        public void Initialize()
        {
            repository = new FakeSongRepository();
        }

        [Test]
        public async Task ShouldFetchById()
        {
            const string id = "B8F27EB0-0117-4D6E-80FD-ABEDA9FF733F";

            var song = await repository.GetSongById(id);

            song.Should().NotBeNull();
            song.Id.Should().Be(id);
            song.Author.Should().Be("An Author");
            song.Title.Should().Be("Song Title");
            song.Lyrics.Should().Be("Some lyrics");
        }

        [Test]
        public async Task ShouldFetchByTitle()
        {
            const string title = "A new title";

            var songs = await repository.GetSongsByTitle(title);

            songs.Count.Should().Be(1);
            songs[0].Title.Should().Be(title);
        }

        [Test]
        public async Task ShouldFetchByAuthor()
        {
            const string author = "Also an author";

            var songs = await repository.GetSongsByAuthor(author);

            songs.Should().NotBeNull();
            songs[0].Author.Should().Be(author);
        }

        [Test]
        public async Task ShouldFetchByLyricsWithLimit()
        {
            const string lyrics = "lyrics";
            const int limit = 2;

            var songs = await repository.GetSongsByLyrics(lyrics, limit);

            songs.Count.Should().Be(2);
        }

        [Test]
        public async Task ShouldFetchByLyricsWithoutLimit()
        {
            const string lyrics = "lyrics";

            var songs = await repository.GetSongsByLyrics(lyrics);

            songs.Count.Should().Be(3);
        }

        [Test]
        public async Task ShouldAddNewSong()
        {
            var song = new Song
            {
                Id = "930B9289-6783-49D2-ADF7-47BEDD6F0FDE",
                Author = "Rob Seaver",
                Title = "Blue Yodel #100",
                Lyrics = "Yodel-ay-ee-hoo"
            };

            var newSong = await repository.AddSong(song);

            newSong.Should().BeEquivalentTo(song);
        }

        [Test]
        public async Task ShouldDeleteSong()
        {
            const string id = "29130D1D-03A5-436D-9D64-034D2D50FE60";

            await repository.DeleteSong(id);

            var missingSong = await repository.GetSongById(id);

            missingSong.Should().BeNull();
        }
    }
}
