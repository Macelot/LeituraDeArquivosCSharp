using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuscaProduto
{
    class Produto
    {
       public string nomeProduto {get; set; }
       public float precoProduto { get; set; }
       public Produto(string n, float p) {
           nomeProduto = n;
           precoProduto = p;
       }

    }
}
