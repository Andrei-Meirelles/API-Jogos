using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
namespace projeto1
{

    [ApiController]

    [Route("api/[Controller]")]

    public class ControllerJogo : ControllerBase
    {
        private readonly JogosService _service;

        public ControllerJogo(JogosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get3(int page = 1, int pagesize = 10)
        {
            var jogos = await _service.Get2(page, pagesize);
            if (jogos.Count == 0)
            {
                return NotFound("Lista vazia");
            }
            return Ok(jogos);

        }

        [HttpPost("Status")]

    public async Task<IActionResult> Postar([FromForm] DtoRequest jogodto)
        {
            var Novojogo = await _service.Post(jogodto);

            if (Novojogo == null)
            {
                return BadRequest("Informações inválidas");
            }
            return Created("", Novojogo);

        }

        [HttpPut("{Id}")]

        public async Task<IActionResult> Update([FromForm]DtoRequest jogodto, int Id)
        {
            var jogoAtualizado = await _service.Put(jogodto, Id);
            if (jogoAtualizado == null)
            {
                return NotFound("Usuario não encontrado");
            }

            return Ok(jogoAtualizado);

        }




        [HttpDelete("{Id}")]

        public async Task<IActionResult> Deletar(int Id)
        {
            var jogoruim = await _service.Delete(Id);

            if (jogoruim == false)
            {
                NotFound("Usuario não encontrado");
            }

            return Ok("Usuario deletado");
        }

        [HttpGet("{Id:int}")]
        public async Task<IActionResult> GetById3(int Id)
        {
            var jogoPorId = await _service.GetById2(Id);
            if(jogoPorId == null)
            {
                return NotFound("Não encontrado");
            }
            return Ok(jogoPorId);
        }
        


         [HttpGet("{Name}")]
         public async Task<IActionResult> GetByName(string Name)
        {
            var jogoPorNome = await _service.GetByName(Name);
            if(jogoPorNome == null)
            {
                return NotFound("Não encontrado");
            }
            return Ok(jogoPorNome);
        }
}
}