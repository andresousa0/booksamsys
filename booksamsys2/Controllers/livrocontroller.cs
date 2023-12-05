using BookSamsys.Services;
using booksamsys2.entidades;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace booksamsys2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }


        [HttpGet]
        [Route("livros")]
        public async Task<IEnumerable<livro>> GetLivros()
        {
            return await _livroService.ObterTodosLivros();
        }

        // POST: api/Livro
        [HttpGet]
        [Route("livros/{isbn}")]
        public async Task GetLivro(string isbn)
        {
            await _livroService.ObterLivroPorIsbn(isbn);
        }

        [HttpPost]
        [Route("criar livro")]
        public async Task PostLivro(livro livro)
        {
            await _livroService.AdicionarLivro(livro);
        }

        [HttpPatch]
        [Route("atualizar livro")]
        public async Task UpdateLivro(livro isbn)
        {
            await _livroService.AtualizarLivro(isbn);
        }
        [HttpDelete]
        [Route("apagarLivro/{isbn}")]
        
        public async Task DeleteLivro(string isbn) 
        {
            await _livroService.RemoverLivro(isbn);
        }
    }
}


