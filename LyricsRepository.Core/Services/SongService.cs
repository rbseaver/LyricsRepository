using System.Threading.Tasks;
using LyricsRepository.Core.Data;

namespace LyricsRepository.Core
{
    public class SongService
    {
        private ISongRepository songRepository;

        public SongService()
        {
        }

        public SongService(ISongRepository songRepository)
        {
            this.songRepository = songRepository;
        }

        public async Task<Song> GetSongById(string id)
        {
            return await songRepository.GetSongById(id);
        }
    }
}