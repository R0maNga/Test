using AutoMapper;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Web.API.Request;
using Web.API.Response;
using Web.API.Response.TextController.Get;

namespace Web.API.Controllers
{   //дефолтный роутинг
    [Route("api/[controller]")]
    [ApiController]
    public class TextController: ControllerBase
    {
        private readonly ILogger<TextController> _logger;
        private readonly ITextService _textService;
        private readonly IMapper _mapper;

        public TextController(ILogger<TextController> logger, ITextService textService, IMapper mapper )
        {
            _logger = logger;
            _textService = textService;
            _mapper = mapper;
        }
        // GET: api/<Textcontroller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var texts = _mapper.Map<IEnumerable<GetTextResponse>>(await _textService.Get());
                if (texts.Count() == 0)
                {
                    return NoContent();
                }
                return Ok(texts);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // POST: api/<Textcontroller>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostTextRequest text)
        {
            try
            {
                await _textService.Create(_mapper.Map<BLL.Entities.Text>(text));
                return Ok("Текс добавлен");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        // PUT: api/<Textcontroller>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PutTextRequest text)
        {
            try
            {
                await _textService.Update(_mapper.Map<BLL.Entities.Text>(text));
                return Ok("Текст изменен");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // DELETE: api/<Textcontroller>
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteTextRequest text)
        {
            try
            {
                await _textService.Delete(_mapper.Map<BLL.Entities.Text>(text));
                return Ok("Текст удален");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
