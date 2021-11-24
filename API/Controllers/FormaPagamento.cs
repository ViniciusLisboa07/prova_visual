using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/formaPagamento")]
    public class FormaPagamentoController : ControllerBase
    {
        private readonly DataContext _context;

        //Construtor
        public FormaPagamentoController(DataContext context) => _context = context;

        //Post: api/formaPagamento/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] FormaPagamento formaPagamento)
        {
            _context.FormaPagamento.Add(formaPagamento);
            _context.SaveChanges();
            return Created("", formaPagamento);
        }

        //GET: api/formaPagamento/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.FormaPagamento.ToList());

    }
}