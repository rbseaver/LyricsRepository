using LyricsRepository.Core;
using LyricsRepository.Core.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LyricsRepository.Tests.Unit
{
    public class FakeSongRepository : ISongRepository
    {
        private readonly IList<Song> songs = new List<Song>
        {
            new Song
            {
                Id = "B8F27EB0-0117-4D6E-80FD-ABEDA9FF733F",
                Author = "An Author",
                Title = "Song Title",
                Lyrics = "Some lyrics"
            },
            new Song
            {
                Id = "71A68327-407F-4AE5-A1E8-644CD0D3AA1E",
                Author = "Also an author",
                Title = "A new title",
                Lyrics = "Lots of lyrics"
            },
            new Song
            {
                Id = "29130D1D-03A5-436D-9D64-034D2D50FE60",
                Author = "Derpy McDerpface",
                Title = "Cool Title Bruh",
                Lyrics = "lyrics galore"
            }
        };

        public async Task<Song> GetSongById(string id)
        {
            return await Task.FromResult(songs.FirstOrDefault(x => x.Id.Equals(id)));
        }

        public async Task<IList<Song>> GetSongsByTitle(string title)
        {
            var results = songs.Where(x => x.Title.Contains(title)).ToList();
            return await Task.FromResult(results);
        }

        public async Task<IList<Song>> GetSongsByAuthor(string author)
        {
            var results = songs.Where(x => x.Author.Contains(author)).ToList();
            return await Task.FromResult(results);
        }

        public async Task<IList<Song>> GetSongsByLyrics(string lyrics, int limit = 0)
        {
            var take = limit == 0 ? songs.Count : limit;
            var results = songs.Take(take).Where(x => x.Lyrics.Contains(lyrics)).ToList();
            return await Task.FromResult(results);
        }

        public async Task<Song> AddSong(Song song)
        {
            songs.Add(song);
            var result = songs.FirstOrDefault(x => x.Id.Equals(song.Id));
            return await Task.FromResult(result);
        }

        public Task DeleteSong(string id)
        {
            return Task.Run(() =>
            {
                var delete = songs.FirstOrDefault(x => x.Id.Equals(id));
                songs.Remove(delete);
            });
        }
    }
}