using Contatos.Domain.Interfaces;
using Contatos.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Contatos.Web.Controllers
{
    public class ContatosController : Controller
    {
        private readonly ContatoService _contatoService;
        private readonly IRepository<Contato> _contatoRepository;
        public ContatosController(ContatoService contatoService,
            IRepository<Contato> contatoRepository)
        {
            _contatoService = contatoService;
            _contatoRepository = contatoRepository;
        }
        [HttpGet]
        public IEnumerable<Contato> GetContatos()
        {
            var contatos = _contatoRepository.GetAll();
            return (contatos);
        }
        [HttpGet("{id}")]
        public ActionResult<Contato> GetContato(int id)
        {
            var contato = _contatoRepository.GetById(id);
            if (contato == null)
            {
                return NotFound(new { message = $"Contato de id={id} não encontrado" });
            }
            return contato;
        }
    }
}