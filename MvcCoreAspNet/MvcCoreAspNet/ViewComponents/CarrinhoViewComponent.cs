using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAspNet.ViewComponents
{
    [ViewComponent(Name = "Carrinho")] //Alias para a class
    public class CarrinhoViewComponent : ViewComponent
    {
        //Simula uma chamada de um banco de dados para carregar os itens do
        //carrinho.
        //Pra isso eh preciso de uma propriedade (itensCarrinho {get; set;}
        //Um construtor CarrinhoViewComponent(), que simula uma ida a um
        //banco de dados e traz o valor de 3 itens

        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            ItensCarrinho = 3;
        }

        public IViewComponentResult Invoke()
        {
            //Esta view não eh uma view MVC, é nessário criar a estrutura para esta view no:
            // - Views/Shared - Criar a estrura abaixo:
            //New Folders - Components/Carrinho (esse nome é o mesmo que está da composição
            //de nome da class "CarrinhoViewComponent"
            //Será criada uma view em /Views/Shared/compenents/Carrinho/com nome Default, q eh
            //o nome padrao no C#
            //Coloca dentro do parenteses o dado (ItensCarrinho) que se quer passar para a view

            return View(ItensCarrinho);
        }


    }
}
