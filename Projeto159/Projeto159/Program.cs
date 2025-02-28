using Projeto159.Entities.Enums;
using Projeto159.Entities;
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomID = new Random();

            int orderID = randomID.Next(100000, 1000000);


            Console.WriteLine("Novo pedido em processamento: ");
            Console.WriteLine("Pedido : " + orderID);

            OrderStatus status = OrderStatus.Pending;

            Console.WriteLine("Status atual: " + status);

            Console.WriteLine("Para confirmar o pedido de prosseguimento.");

            Order newOrder = new Order(orderID , status);

            Console.WriteLine("Qual novo status do pedido?");

            Console.WriteLine("Digite um dos seguintes status:");
            Console.WriteLine("1 - Pending");
            Console.WriteLine("2 - Processing");
            Console.WriteLine("3 - Shipped");
            Console.WriteLine("4 - Delivered");

            string statusTemp = Console.ReadLine();

            OrderStatus newStatus;

            switch (statusTemp)
            {
                case "1":
                    newStatus = OrderStatus.Pending;
                    break;
                case "2":
                    newStatus = OrderStatus.Processing;
                    break;
                case "3":
                    newStatus = OrderStatus.Shipped;
                    break;
                case "4":
                    newStatus = OrderStatus.Delivered;
                    break;
                default:
                    Console.WriteLine("Erro ao selecionar, status nao alterado.");
                    return;
            }

            newOrder.ChangeStatus(newStatus);

            Console.WriteLine("Status alterado.");
            Console.WriteLine($"Novo status do pedido {orderID}: {newStatus}");



        }
    }
}