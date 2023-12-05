using booksamsys2.entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSamsys.Repository;

public class LivroRepository : ILivroRepository
{
    private readonly AppDBcontext _context;

    public LivroRepository(AppDBcontext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<livro>> ObterTodos()
    {
        return await _context.Livros.ToListAsync();
    }

    public async Task<livro> ObterPorId(int id)
    {
        return await _context.Livros.FindAsync(id);
    }

    public async Task AdicionarLivro(livro livro)
    {
        _context.Livros.Add(livro);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarLivro(livro livro)
    {
        _context.Entry(livro).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task RemoverLivro(int id)
    {
        var livro = await _context.Livros.FindAsync(id);
        _context.Livros.Remove(livro);
        await _context.SaveChangesAsync();
    }
}
