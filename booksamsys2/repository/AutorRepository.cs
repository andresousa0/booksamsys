using booksamsys2.entidades;
using booksamsys2.repository;
using booksamsys2;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSamsys.Repository;
public class AutorRepository : IAutorRepository
{
    private readonly AppDBcontext _context;

    public AutorRepository(AppDBcontext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<autor>> ObterTodos()
    {
        return await _context.Autores.ToListAsync();
    }

    public async Task<autor> ObterPorId(int id)
    {
        return await _context.Autores.FindAsync(id);
    }

    public async Task AdicionarAutor(autor autor)
    {
        _context.Autores.Add(autor);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAutor(autor autor)
    {
        _context.Entry(autor).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAutor(int id)
    {
        var autor = await _context.Autores.FindAsync(id);
        _context.Autores.Remove(autor);
        await _context.SaveChangesAsync();
    }
}

