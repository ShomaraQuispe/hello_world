using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")] //esta classe trabalhadora vai trabalhar na raiz. "~" indica a raiz.
    [ApiController] // informa aqui q ela é classe controladora
    public class HelloController
    {
        [HttpGet] //equivale ao CONSOLEWRITELINE. O verbo GET pega a informação e visualiza
        public string Hello() //metodo do tipo string
        {
            return "Hello World!";
        }

        [HttpGet("/bsm")]
        public string Bsm()
        {
            return "Conheça aqui as BSM's da Generation Brasil:\n\nMentalidades:\nResponsabilidade Pessoal\nMentalidade de Crescimento\nOrientação ao Futuro\nPersistência\n\n" +
                "Habilidades Comportamentais:\nComunicação\nOrientação aos Detalhes\nTrabalho em Equipe\nProatividade";
        }

        [HttpGet("/obj")]
        public string Objetivo()
        {
            return "Lista de aprendizado desta semana: introdução ao AspNet, diagramas DER e inicio do projeto do blog pessoal";
        }

    }
}
