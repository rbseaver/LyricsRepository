namespace LyricsRepository.Core.Providers
{
    public class AssemblyProvider : IAssemblyProvider
    {
        public string GetVersion<T>()
        {
            return typeof(T).Assembly
                .GetName()
                .Version
                .ToString();
        }
    }
}
