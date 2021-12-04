
using System.Linq;
using System.Collections.Generic;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/venda")]
    public class VendaController : ControllerBase
    { private readonly DataContext _context;

        //Construtor
        public VendaController(DataContext context) => _context = context;

        //Post: api/formaPagamento/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Venda venda)
        {
            venda.FormaPagamento = _context.FormaPagamento.Find(venda.FormaPagamentoId);
            List<ItemVenda> itens =  _context.ItemVenda.Where(item => item.CarrinhoId == venda.CarrinhoId).ToList();
            venda.Itens = itens;
            _context.Vendas.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
        }

        //GET: api/venda/list
        //ALTERAR O MÉTODO PARA MOSTRAR TODOS OS DADOS DA VENDA E OS DADOS RELACIONADOS
        [HttpGet]
        [Route("list")]
        public IActionResult List() =>
            Ok(_context.Vendas.Include(venda => venda.FormaPagamento).ToList());
    }
}