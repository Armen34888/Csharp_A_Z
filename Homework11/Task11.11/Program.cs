namespace Task11._11
{
    internal class Program
    {
        //Enum-Based Strategy Pattern:
        public enum PaymentGateway
        {
            PayPal,
            Stripe,
            CreditCard
        }
        // Step 2: Define the IPaymentProcessor interface
        public interface IPaymentProcessor
        {
            void ProcessPayment(double amount);
        }

        // Step 3: Implement concrete payment processor classes
        public class PayPalPaymentProcessor : IPaymentProcessor
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing PayPal payment of ${amount}");
                // Implement PayPal payment processing logic here
            }
        }

        public class StripePaymentProcessor : IPaymentProcessor
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing Stripe payment of ${amount}");
                // Implement Stripe payment processing logic here
            }
        }

        public class CreditCardPaymentProcessor : IPaymentProcessor
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine($"Processing Credit Card payment of ${amount}");
                // Implement Credit Card payment processing logic here
            }
        }

        // Step 4: Factory method to return payment processor based on enum value
        public class PaymentProcessorFactory
        {
            public static IPaymentProcessor GetPaymentProcessor(PaymentGateway gateway)
            {
                switch (gateway)
                {
                    case PaymentGateway.PayPal:
                        return new PayPalPaymentProcessor();
                    case PaymentGateway.Stripe:
                        return new StripePaymentProcessor();
                    case PaymentGateway.CreditCard:
                        return new CreditCardPaymentProcessor();
                    default:
                        throw new ArgumentException("Invalid payment gateway");
                }
            }
        }

        static void Main(string[] args)
        {
            // Example usage of the strategy pattern with enums
            PaymentGateway selectedGateway = PaymentGateway.PayPal;
            double amount = 100.0;

            // Get the appropriate payment processor based on the selected gateway
            IPaymentProcessor processor = PaymentProcessorFactory.GetPaymentProcessor(selectedGateway);

            // Process payment using the selected processor
            processor.ProcessPayment(amount);
        }
    }
}
