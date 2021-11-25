using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { CategoriaId = 1, Nome = "BMW" },
                    new Categoria { CategoriaId = 2, Nome = "Volkswagen" },
                    new Categoria { CategoriaId = 3, Nome = "Peugeot" },
                    new Categoria { CategoriaId = 4, Nome = "Chevrolet" },
                    new Categoria { CategoriaId = 5, Nome = "Renault" },
                    new Categoria { CategoriaId = 6, Nome = "Ford" },
                }
            );
            _context.Produtos.AddRange(new Produto[]
                {
                    new Produto { ProdutoId = 1, Nome = "X5",        Descricao = "Ótimo Carro",      Preco = 20, Quantidade = 1, CategoriaId = 1 },
                    new Produto { ProdutoId = 2, Nome = "Gol G5",    Descricao = "Quebra o galho",   Preco = 60,  Quantidade = 2, CategoriaId = 2 },
                    new Produto { ProdutoId = 3, Nome = "207",       Descricao = "Nem de graça",     Preco = 1,  Quantidade = 3, CategoriaId = 3 },
                    new Produto { ProdutoId = 4, Nome = "Onix",      Descricao = "Caro",             Preco = 32, Quantidade = 1, CategoriaId = 4 },
                    new Produto { ProdutoId = 5, Nome = "Kmid",      Descricao = "Feito de Plastico",Preco = 54, Quantidade = 2, CategoriaId = 5 },
                    new Produto { ProdutoId = 6, Nome = "Mustang",   Descricao = "Sem peça",         Preco = 43, Quantidade = 3, CategoriaId = 6 },
                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }
    }
}