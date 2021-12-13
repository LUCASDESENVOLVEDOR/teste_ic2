using E_JOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult representa retorno de status HTTP.

        Equipe equipeModel = new Equipe();


        //500 erro

        //200 OK


        [Route("Listar")]
        public IActionResult Index()
        {
            //VIEW = responsavel pela exibição do frontend.
               

            //ViewBag = ARMAZENAS AS INFORMACOES DO BACKEND
            // PARA SEREM ACESSADAS NO FRONTEND. (CONTROLLER PARA A  VIEW)

            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }


        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = int.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            equipeModel.Create(novaEquipe);  //funcao criar.          
            ViewBag.Equipes = equipeModel.ReadAll();

            return LocalRedirect("~/Equipe/Listar"); //rota que criamos
        }






    }
}
