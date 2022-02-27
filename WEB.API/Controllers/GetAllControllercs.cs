

using AutoMapper;
using BLL.Services;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Web.API.Response;
using Web.API.Response.GetAllControllersModel.GettAll;

namespace Web.API.Controllers
{
    //дефолиный роутинг
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllController : ControllerBase
    {




        private readonly IAuthorService _authorService;
        private readonly ITextService _textService;
        private readonly IPhotoService _photoService;
        private readonly IMapper _mapper;

        public GetAllController(IAuthorService authorService, IPhotoService photoService, ITextService textService, IMapper mapper)
        {
            _authorService = authorService;
            _textService = textService;
            _photoService = photoService;
            _mapper = mapper;
        }
        // GET: api/<GetAllController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var authors = _mapper.Map<IEnumerable<AuthorGetAllResponse>>(await _authorService.GetFullInfo());


                return Ok(authors);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
