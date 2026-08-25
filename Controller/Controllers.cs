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
    public async Task<IActionResult> Get()
        {
            var jogos = await _service.Get();
            if (jogos.Count == 0)
            {
                return NotFound("Lista vazia");
            }
            return Ok(jogos);
            
        }

    [HttpPost]

    public async Task<IActionResult> Postar()
        {
            
        }

        [HttpPut]

        public async Task<IActionResult> Update()
        {
            
        }




        [HttpDelete]

        public async Task<IActionResult> Deletar()
        {
            
        }

}
}