using Confluent.Kafka;

namespace KafkaProducer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            Console.WriteLine("=================================");
            Console.WriteLine("      KAFKA PRODUCER");
            Console.WriteLine("=================================");
            Console.WriteLine("Type a message and press Enter.");
            Console.WriteLine("Type 'exit' to quit.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Message: ");
                string? message = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(message))
                    continue;

                if (message.ToLower() == "exit")
                    break;

                try
                {
                    var result = producer.ProduceAsync(
                        "chat-message",
                        new Message<Null, string>
                        {
                            Value = message
                        }).Result;

                    Console.WriteLine($"Sent: {message}");
                    Console.WriteLine($"Partition: {result.Partition}");
                    Console.WriteLine($"Offset: {result.Offset}");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            producer.Flush(TimeSpan.FromSeconds(5));
        }
    }
}