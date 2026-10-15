using System;

namespace SistemaDePedidos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("--- Iniciando o Sistema de Pedidos --- \n");

            IPayment meioPagamento = new PixPayment();
            OrderService orderService = new OrderService(meioPagamento);
            Order novoPedido = new Order(250);

            try {
                Console.WriteLine("Tentando finalizar o pedido...");
                orderService.PlaceOrder(novoPedido);
                Console.WriteLine("\nPedido finalizado com sucesso!");
            }
            catch (DomainException ex) {
                Console.WriteLine($"\nErro de Domínio: {ex.Message}");
            }
            catch (Exception ex) {
                Console.WriteLine($"\nErro inesperado: {ex.Message}");
            }

            Console.ReadKey();
        }
    }

}
