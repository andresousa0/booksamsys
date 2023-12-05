using BookSamsys.Services;
using booksamsys2.entidades;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace booksamsys2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class autorController : ControllerBase
    {
        private readonly IAutorService _autorService;

        public autorController(IAutorService autorService)
        {
            _autorService = autorService;
        }


        [HttpGet]
        [Route("autores")]
        public async Task<IEnumerable<autor>> GetAutores()
        {
            return await _autorService.ObterTodosAutores();
        }

        // POST: api/Livro
        [HttpGet]
        [Route("autores/{id}")]
        public async Task GetAutor(int id)
        {
            await _autorService.ObterAutorPorId(id);
        }

        [HttpPost]
        [Route("criar autor")]
        public async Task PostLivro(autor autor)
        {
            await _autorService.AdicionarAutor(autor);
        }

        [HttpPatch]
        [Route("atualizar autor")]
        public async Task UpdateAutor(autor autor)
        {
           await _autorService.AtualizarAutor(autor);
        }
        [HttpDelete]
        [Route("apagar autor/{id}")]

        public async Task DeleteAutor(int id)
        {
            await _autorService.RemoverAutor(id);
        }
    }
}
















