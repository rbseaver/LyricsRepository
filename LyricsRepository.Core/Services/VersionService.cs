using LyricsRepository.Api;
using System;
using System.Threading.Tasks;

namespace LyricsRepository.Core
{
    public class VersionService
    {
        private readonly IAssemblyProvider assemblyProvider;

        public VersionService(IAssemblyProvider assemblyProvider)
        {
            this.assemblyProvider = assemblyProvider;
        }

        public async Task<string> GetVersionAsync<T>()
        {
            return await Task.FromResult(assemblyProvider.GetVersion<T>());
        }
    }
}