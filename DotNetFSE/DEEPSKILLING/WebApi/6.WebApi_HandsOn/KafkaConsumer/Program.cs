using Confluent.Kafka;

namespace KafkaConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

            consumer.Subscribe("chat-message");

            Console.WriteLine("=================================");
            Console.WriteLine("       KAFKA CONSUMER");
            Console.WriteLine("=================================");
            Console.WriteLine("Waiting for messages...");
            Console.WriteLine();

            try
            {
                while (true)
                {
                    var result = consumer.Consume();

                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Message : {result.Message.Value}");
                    Console.WriteLine($"Topic   : {result.Topic}");
                    Console.WriteLine($"Partition : {result.Partition}");
                    Console.WriteLine($"Offset  : {result.Offset}");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine();
                }
            }
            catch (OperationCanceledException)
            {
                consumer.Close();
            }
        }
    }
}