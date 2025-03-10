using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace Projeto161.Entities 
{
    class Product // Define a classe Product, que representa um produto no sistema.
    {
        public string NameProduct { get; set; } // Propriedade que armazena o nome do produto. O modificador 'get; set;' permite leitura e escrita.
        public double PriceProduct { get; set; } // Propriedade que armazena o preço do produto. O tipo é 'double' para permitir valores decimais.

        // Construtor padrão, sem parâmetros, que permite criar um objeto Product sem passar dados de entrada.
        public Product() { }

        // Construtor com parâmetros, permitindo criar um objeto Product já com os dados fornecidos.
        public Product(string nameProduct, double priceProduct)
        {
            NameProduct = nameProduct; // Atribui o valor do nome do produto à propriedade 'NameProduct'.
            PriceProduct = priceProduct; // Atribui o valor do preço do produto à propriedade 'PriceProduct'.
        }
    }
}
