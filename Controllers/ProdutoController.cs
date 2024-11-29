using IfoodSocial.Data;
using IfoodSocial.Model;
using IfoodSocial.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IfoodSocial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("consultar")]
        public async Task<IActionResult> ConsultarProdutos(
            [FromQuery] string? nome = null,
            [FromQuery] string? categoria = null,
            [FromQuery] string? empreendimento = null)

        {
            try
            {
                var produtos = await _produtoService.ConsultarProdutos(nome, categoria, empreendimento);
                return Ok(produtos);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

    }
}
