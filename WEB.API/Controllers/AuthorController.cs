
using AutoMapper;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Web.API.Request;
using Web.API.Response;
using Web.API.Response.AuthorController.Get;

namespace Web.API.Controllers
{
    //дефолтный роутинг
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController(ILogger<AuthorController> logger, IAuthorService authorService, IMapper mapper)
        {
            _logger = logger;
            _authorService = authorService;
            _mapper = mapper;
        }
        // GET: api/<AuthorController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                
                var authors =  _mapper.Map<IEnumerable <GetAuthorResponse>> (await _authorService.Get());
                if (authors.Count() ==0)
                {
                    return NoContent();
                }
                return Ok(authors);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }   
        }
        // POST: api/<AuthorController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostAuthorRequest author)
        {
            try
            {
                await _authorService.Create(_mapper.Map<BLL.Entities.Author>(author));
                return Ok("Автор добавлен)");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<AuthorController>
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAuthorRequest author)
        {
            try
            {
                await _authorService.Delete(_mapper.Map<BLL.Entities.Author>(author));
                return Ok("Автор удален");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}   
   
