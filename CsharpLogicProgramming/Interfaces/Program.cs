using System;

namespace SistemaDePedidos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("--- Iniciando o Sistema de Pedidos --- \n");

            IPayment meioPagamento = new PixPayment();
            OrderService orderService = new OrderService(meioPagamento);
            Order novoPedido = new Order(250.00);

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

    public class OrderService {
        private readonly IPayment _paymentService;

        public OrderService(IPayment paymentService) {
            _paymentService = paymentService;
        }

        public void PlaceOrder(Order order) {
            PaymentStatus status = _paymentService.ProcessPayment(order.TotalPrice());

            if (status == PaymentStatus.Failed) {
                throw new DomainException("The payment failed");
            }
        }
    }

    public class PixPayment : IPayment {
        public PaymentStatus ProcessPayment(double amount) {
            Console.WriteLine("-> Conectando ao Banco Central...");
            Console.WriteLine("-> QR Code generated! $" + amount);

            bool sucessfullPayment = false;

            if (sucessfullPayment != true) {
                return PaymentStatus.Failed;
            }
            else {
                return PaymentStatus.Completed;
            }
        }

        public void outro(double amount) {
            Console.WriteLine("QR Code generated! $" + amount);
        }
    }

    public interface IPayment {
        PaymentStatus ProcessPayment(double amount);
    }

    public enum PaymentStatus {
        Failed,
        Pending,
        Completed
    }

    public class Order {
        private readonly double _totalPrice;

        public Order(double totalPrice) {
            _totalPrice = totalPrice;
        }

        public double TotalPrice() {
            return _totalPrice;
        }
    }

    public class DomainException : Exception {
        public DomainException(string message) : base(message) { }
    }
}
