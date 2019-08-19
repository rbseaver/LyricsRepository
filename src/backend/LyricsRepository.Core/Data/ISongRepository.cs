using System.Collections.Generic;
using System.Threading.Tasks;

namespace LyricsRepository.Core.Data
{
    public interface ISongRepository
    {
        Task<Song> AddSong(Song song);
        Task DeleteSong(string id);
        Task<Song> GetSongById(string id);
        Task<IList<Song>> GetSongsByAuthor(string author);
        Task<IList<Song>> GetSongsByLyrics(string lyrics, int limit = 0);
        Task<IList<Song>> GetSongsByTitle(string title);
    }
}