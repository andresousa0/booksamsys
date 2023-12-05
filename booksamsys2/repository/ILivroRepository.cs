
using booksamsys2.entidades;

namespace BookSamsys.Repository
{
    public interface ILivroRepository
    {
        Task<IEnumerable<livro>> ObterTodos();
        Task<livro> ObterPorId(int id);
        Task AdicionarLivro(livro livro);
        Task AtualizarLivro(livro livro);
        Task RemoverLivro(int id);
    }
}
