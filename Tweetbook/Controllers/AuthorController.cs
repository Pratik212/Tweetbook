using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tweetbook.Models;
using WebApiPractice.Interfaces;

namespace WebApiPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllAuthor()
        {
            var result = await _authorRepository.GetAllAuthor();

            return Ok(new
            {
                result
            });
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] Author author)
        {
            var result = await _authorRepository.Add(author);

            if (author == null)
            {
                return NotFound();
            }
            
            return Ok(new
            {
                result.Id,
                result.Name
            });
        }
    }
}