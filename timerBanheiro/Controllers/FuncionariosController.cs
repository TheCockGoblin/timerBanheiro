using Microsoft.AspNetCore.Mvc;
using timerBanheiro.Models;

namespace timerBanheiro.Controllers
{
    public class FuncionariosController : Controller
    {
        private static List<FuncionariosModel> _funcionario = new List<FuncionariosModel>
        {

            new FuncionariosModel
            {
                id = 1,
                nome = "Jorge",
                sexo = "H",
                statusIdade = "2",
                pcd = 0,
                tempoSecs = 60 + 30

            },

            new FuncionariosModel
            {
                id = 2,
                nome = "Renato Aragão",
                sexo = "H",
                statusIdade = "3",
                pcd = 0,
                tempoSecs = 60 + 60
            },

            new FuncionariosModel
            {
                id = 3,
                nome = "Amanda Amada",
                sexo = "F",
                statusIdade = "2",
                pcd = 0,
                tempoSecs = 60 + 30 + 30
            },

            new FuncionariosModel
            {
                id = 4,
                nome = "Lorena",
                sexo = "F",
                statusIdade = "2",
                pcd = 1,
                tempoSecs = 60 + 60 + 30 + 30
            }
        };

        public IActionResult Index()
        {
           return View(_funcionario);
        }

        [HttpGet]
        public IActionResult GetFuncionario(int id)
        {
            var func = _funcionario.FirstOrDefault(c => c.id == id);
            if (func == null)
            {
                return NotFound(); 
            }

            return Json(func);
        }
    }
};