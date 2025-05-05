using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace PortalProdutos.Pages
{
    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void OnGet()
        {
            Produtos.AddRange(new[] {
                new Produto { Nome = "Notebook", Preco = 3500.00m },
                new Produto { Nome = "Mouse", Preco = 89.90m },
                new Produto { Nome = "Teclado", Preco = 120.50m }
            });
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}