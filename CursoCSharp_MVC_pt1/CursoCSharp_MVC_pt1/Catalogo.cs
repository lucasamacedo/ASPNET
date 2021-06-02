using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp_MVC_pt1
{
    public class Catalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu na minha Query?", 12.99m));
            livros.Add(new Livro("002", "Fique Rico com C#", 30.99m));
            livros.Add(new Livro("003", "Java para baixinhos", 25.99m));
            return livros;
        }
    }
}
