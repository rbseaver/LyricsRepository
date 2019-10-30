using System.Threading.Tasks;
using LyricsRepository.Core;
using Microsoft.AspNetCore.Mvc;

namespace LyricsRepository.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private readonly IVersionService versionService;

        public VersionController(IVersionService versionService)
        {
            this.versionService = versionService;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            return await versionService.GetVersionAsync<Startup>();
        }
    }
}
