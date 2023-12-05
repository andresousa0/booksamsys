using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace booksamsys2.entidades
{

    public class livro
    {
        [Key]
        public string isbn { get; set; }

        public string nome { get; set; }

        public int autorId { get; set; }

        public decimal preco { get; set; }

        public autor autor { get; set; }
    }
}

