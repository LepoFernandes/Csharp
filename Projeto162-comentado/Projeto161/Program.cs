using Projeto161.Entities; // Importa as entidades definidas no namespace Projeto161.Entities.
using Projeto161.Entities.Enums; // Importa o enum OrderStatus definido em Projeto161.Entities.Enums.
using System; // Importa a biblioteca básica do C#.
using System.Globalization; // Importa para usar o CultureInfo.InvariantCulture para garantir a formatação correta de números decimais.

namespace Curso // Define o namespace do programa.
{
    class Program // Define a classe Program, que contém o ponto de entrada do aplicativo.
    {
        static void Main(string[] args) // Método principal, o ponto de entrada do programa.
        {
            // Solicita os dados do cliente.
            Console.WriteLine("Enter client data:");
            Console.Write("Name:");
            string nameClient = Console.ReadLine(); // Lê o nome do cliente.

            Console.Write("Email:");
            string email = Console.ReadLine(); // Lê o email do cliente.

            Console.Write("Birth date (DD/MM/YYYY) : ");
            DateTime birthday = DateTime.Parse(Console.ReadLine()); // Lê e converte a data de nascimento do cliente para o tipo DateTime.

            // Cria um objeto 'Client' usando os dados coletados.
            Client client = new Client(nameClient, email, birthday);

            // Solicita os dados do pedido.
            Console.WriteLine("Enter order data:");
            Console.WriteLine("Status: " + OrderStatus.Processing); // Informa que o status inicial do pedido será 'Processing' (Processando).
            Console.WriteLine("How many items to this order?");

            // Lê o número de itens que o pedido terá.
            int N = int.Parse(Console.ReadLine());

            // Cria um objeto 'Order' para armazenar os itens do pedido.
            Order order = new Order();

            // Laço que percorre o número de itens do pedido.
            for (int i = 1; i <= N; i++) // Começa do item 1 até o número de itens N.
            {
                Console.WriteLine("Enter #" + i + " item data:"); // Exibe qual item o usuário está adicionando.

                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine(); // Lê o nome do produto.

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê o preço do produto, garantindo a formatação correta de números decimais.

                // Cria um objeto 'Product' com o nome e preço fornecidos.
                Product produto1 = new Product(nameProduct, price);

                // Solicita a quantidade do produto.
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine()); // Lê a quantidade do produto.

                // Cria um objeto 'OrderItem' com a quantidade, preço e produto.
                OrderItem orderN = new OrderItem(quantity, price, produto1);

                // Adiciona o item à lista de itens do pedido.
                order.AddItem(orderN);
            }

            // Exibe o resumo do pedido, chamando o método ToString() da classe 'Order'.
            Console.WriteLine(order.ToString());
        }
    }
}
