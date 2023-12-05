using booksamsys2.entidades;
using booksamsys2.repository;
 
namespace BookSamsys.Services;

public interface ILivroService

{

    Task<IEnumerable<livro>> ObterTodosLivros();

    Task<livro> ObterLivroPorIsbn(string isbn);

    Task AdicionarLivro(livro livro);

    Task AtualizarLivro(livro livro);

    Task RemoverLivro(string isbn);

}

