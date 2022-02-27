
using AutoMapper;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Web.API.Request;
using Web.API.Response;
using Web.API.Response.PhotoController.Get;

namespace Web.API.Controllers
{   //дефолтный роутинг
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly ILogger<PhotoController> _logger;
        private readonly IPhotoService _photoService;
        private readonly IMapper _mapper;

        public PhotoController(ILogger<PhotoController> logger, IPhotoService photoService, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _photoService = photoService;

        }
        // GET: api/<PhotoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            try
            {
                var photos = _mapper.Map<IEnumerable<GetPhotoResponse>>(await _photoService.Get());
                if (photos.Count() == 0)
                {
                    return NoContent();
                }
                
                return Ok(photos);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET: api/<PhotoController>/2
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var photo = _mapper.Map<GetPhotoResponse>(await _photoService.GetById(id));
                if (photo == null)
                {
                    return NoContent();
                }
                return Ok(photo);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST: api/<PhotoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostPhotoRequest photo)
        {
            try
            {
                await _photoService.Create(_mapper.Map<BLL.Entities.Photo>(photo));
                return Ok("Фото добавлено");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        // PUT: api/<PhotoController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PutPhotoRequest photo)
        {
            try
            {
                await _photoService.Update(_mapper.Map<BLL.Entities.Photo>(photo));
                return Ok("Фото изменено");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // DELETE: api/<PhotoController>
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeletePhotoRequest photo)
        {
            try
            {
                await _photoService.Delete(_mapper.Map<BLL.Entities.Photo>(photo));
                return Ok("Фото удалено");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
            
    }
    
}
