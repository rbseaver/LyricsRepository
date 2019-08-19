using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LyricsRepository.Core.Data
{
    class SongRepository : ISongRepository
    {
        public Task<Song> AddSong(Song song)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSong(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Song> GetSongById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Song>> GetSongsByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Song>> GetSongsByLyrics(string lyrics, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Song>> GetSongsByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
