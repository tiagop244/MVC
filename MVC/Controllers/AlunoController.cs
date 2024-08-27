using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            AlunoController a1 = new Aluno(1, "Tiago Pereira", "tiagopereira@teste.com.br", 123456);
            AlunoController a2 = new Aluno(2, "Januario silva", "januariosilva@teste.com.br", 223344);
            AlunoController a3 = new Aluno(3, "Nobru Goes", "nobrugoes@teste.com.br", 333666);
            AlunoController a4 = new Aluno(4, "Cristiano Ronaldo", "cr7thegoat@teste.com.br", 444444);
            AlunoController a5 = new Aluno(5, "Cesar costa", "cesarcosta@teste.com.br", 557788);

            List<Aluno> listaAlunos = new List<Aluno>();

            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);

            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }

}
