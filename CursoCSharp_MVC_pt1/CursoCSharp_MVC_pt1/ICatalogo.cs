using System.Collections.Generic;

namespace CursoCSharp_MVC_pt1
{
    public interface ICatalogo
    {
        List<Livro> GetLivros();
    }
}