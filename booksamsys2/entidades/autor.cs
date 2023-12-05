using System.ComponentModel.DataAnnotations;
using booksamsys2.entidades;
using Microsoft.EntityFrameworkCore;
namespace booksamsys2
{
    public class autor
    {
        [Key]
        public int id_autor { get; set; }
        public string nome { get; set; }

        public List<livro> Livros { get; set; } = new List<livro>();
    }
}
