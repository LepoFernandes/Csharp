using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Projeto161.Entities.Enums;
using System.Globalization;

namespace Projeto161.Entities 
{
    class Order // Define a classe Order, que representa um pedido no sistema.
    {
        public OrderStatus status { get; set; } // Propriedade que armazena o status do pedido (PendingPayment, Processing, Shipped, Delivered). Tipo 'OrderStatus', que é um enum.
        public DateTime moment = DateTime.Now; // Propriedade que armazena o momento (data e hora) em que o pedido foi criado. Inicializa com a data e hora atual.
        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); // Propriedade que armazena a lista de itens do pedido. Inicializa com uma lista vazia.

        // Construtor padrão, sem parâmetros. Pode ser usado para criar um pedido sem informações específicas (status, momento).
        public Order() { }

        // Construtor com parâmetros, permitindo definir o status e o momento do pedido na hora de sua criação.
        public Order(OrderStatus status, DateTime moment)
        {
            this.status = status; // Atribui o valor do status à propriedade 'status'.
            this.moment = moment; // Atribui o valor do momento à propriedade 'moment'.
        }

        // Método para adicionar um item ao pedido. Recebe um objeto 'OrderItem' e o adiciona à lista 'Items'.
        public void AddItem(OrderItem items)
        {
            Items.Add(items); // Adiciona o item à lista 'Items'.
        }

        // Método para remover um item do pedido. Recebe um objeto 'OrderItem' e o remove da lista 'Items'.
        public void RemoveItem(OrderItem items)
        {
            Items.Remove(items); // Remove o item da lista 'Items'.
        }

        // Método que calcula o valor total do pedido somando os subtotais dos itens. Usa o LINQ para iterar sobre os itens e somar seus subtotais.
        public double Total()
        {
            return Items.Sum(item => item.subtotal()); // Retorna a soma dos subtotais de todos os itens no pedido.
        }

        // Método sobrescrito ToString que retorna uma string representando o resumo do pedido.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Instancia um objeto StringBuilder, que é mais eficiente para concatenar strings.

            sb.AppendLine("ORDER SUMMARY"); // Adiciona o título "ORDER SUMMARY".
            sb.AppendLine("Order Moment: " + moment); // Adiciona a data e hora do pedido.
            sb.AppendLine("Order Status: " + status); // Adiciona o status do pedido.
            sb.AppendLine("Order items:"); // Adiciona o título "Order items:".

            // Loop que percorre a lista de itens do pedido e adiciona detalhes sobre cada item.
            foreach (var item in Items)
            {
                sb.AppendLine(item.product.NameProduct + ", " + // Nome do produto.
                    item.quantity + " units, " + // Quantidade do produto.
                    "$" + item.product.PriceProduct.ToString("F2") + // Preço unitário do produto formatado com 2 casas decimais.
                    " each, Subtotal: $" + item.subtotal().ToString("F2")); // Subtotal do item formatado com 2 casas decimais.
            }

            sb.AppendLine("Total: $" + Total().ToString("F2")); // Adiciona o total do pedido, formatado com 2 casas decimais.
            return sb.ToString(); // Retorna a string gerada.
        }
    }
}
