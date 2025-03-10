using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Projeto161.Entities.Enums 
{
    internal enum OrderStatus : int // Define um enum chamado OrderStatus com um valor base de tipo inteiro (int).
    {
        PendingPayment = 0, // Representa o status do pedido aguardando pagamento. Mapeado para o valor inteiro 0.
        Processing = 1, // Representa o status do pedido em processamento. Mapeado para o valor inteiro 1.
        Shipped = 2, // Representa o status do pedido enviado. Mapeado para o valor inteiro 2.
        Delivered = 3 // Representa o status do pedido entregue. Mapeado para o valor inteiro 3.
    }
}
