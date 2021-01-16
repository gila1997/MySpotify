using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ServerPlayer.Model;
using ServerPlayer.Service;

namespace ServerPlayer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {

        private readonly ILogger<MusicController> _logger;
        private IMusicRepository _musicRepository;
        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
            var optionsBuilder = new DbContextOptionsBuilder<MusicContext>();
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
            _musicRepository = new SqlMusicRepository(optionsBuilder);
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var result = await _musicRepository.Users.InserAsync(user);
            return Ok(result);
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var result = 
                (await _musicRepository.Users.AuthenticateAsync(user));
            return Ok(result);
        }

        [HttpPost("getAlbums")]
        public async Task<IActionResult> GetAlbums(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var result =
                (await _musicRepository.Users.GetAlbums((int)id));
            return Ok(result);
        }


    }
}
