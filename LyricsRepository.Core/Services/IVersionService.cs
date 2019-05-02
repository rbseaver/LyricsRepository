using System.Threading.Tasks;

namespace LyricsRepository.Core
{
    public interface IVersionService
    {
        Task<string> GetVersionAsync<T>();
    }
}