using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto161.Entities 
{
    class OrderItem // Define a classe OrderItem, que representa um item de pedido no sistema.
    {
        public int quantity { get; set; } // Propriedade que armazena a quantidade do item no pedido. Tipo inteiro.
        public double price { get; set; } // Propriedade que armazena o preço do item. Tipo 'double' para valores decimais.

        public Product product { get; set; } // Propriedade que armazena o produto associado ao item do pedido. Tipo 'Product' (ou seja, um objeto da classe 'Product').

        // Construtor padrão, sem parâmetros, que permite criar um objeto OrderItem sem passar dados de entrada.
        public OrderItem() { }

        // Construtor com parâmetros, permitindo criar um objeto OrderItem com os dados fornecidos.
        public OrderItem(int quantity, double price, Product product)
        {
            this.quantity = quantity; // Atribui o valor da quantidade à propriedade 'quantity'.
            this.price = price; // Atribui o valor do preço à propriedade 'price'.
            this.product = product; // Atribui o valor do produto à propriedade 'product'.
        }

        // Método que calcula o subtotal para o item do pedido, multiplicando a quantidade pelo preço.
        public double subtotal()
        {
            return quantity * price; // Retorna o subtotal, que é o preço multiplicado pela quantidade.
        }
    }
}
