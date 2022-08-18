using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Tarefas.Api.Controllers
{
    public class CadastroTarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
