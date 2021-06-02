using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CursoCSharp_MVC_pt1
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}