using Livros_API.Modelos;
using Livros_API.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Livros_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ServicoLivro _servicoLivro;

        public LivrosController(ServicoLivro servicoLivro)
        {
            _servicoLivro = servicoLivro;
        }

        [HttpGet]
        public ActionResult<List<Livro>> Get() =>
            _servicoLivro.Get();

        [HttpGet("{id:length(24)}", Name = "GetLivro")]
        public ActionResult<Livro> Get(string id)
        {
            var livro = _servicoLivro.Get(id);

            if (livro == null)
            {
                return NotFound();
            }

            return livro;
        }

        [HttpPost]
        public ActionResult<Livro> Create(Livro livro)
        {
            _servicoLivro.Create(livro);

            return CreatedAtRoute("GetLivro", new { id = livro.Id.ToString() }, livro);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Livro livroEm)
        {
            var livro = _servicoLivro.Get(id);

            if (livro == null)
            {
                return NotFound();
            }

            _servicoLivro.Update(id, livroEm);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var livro = _servicoLivro.Get(id);

            if (livro == null)
            {
                return NotFound();
            }

            _servicoLivro.Remove(livro.Id);

            return NoContent();
        }
    }
}