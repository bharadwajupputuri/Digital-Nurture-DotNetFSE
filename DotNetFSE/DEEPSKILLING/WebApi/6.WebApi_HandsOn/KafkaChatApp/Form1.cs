using Confluent.Kafka;

namespace KafkaChatApp
{
    public partial class Form1 : Form
    {
        private readonly ProducerConfig producerConfig;
        private readonly ConsumerConfig consumerConfig;
        private readonly CancellationTokenSource cancellationTokenSource =
            new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();

            producerConfig = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            consumerConfig = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = Guid.NewGuid().ToString(),
                AutoOffsetReset = AutoOffsetReset.Latest
            };

            StartConsumer();
        }

        private async void StartConsumer()
        {
            await Task.Run(() =>
            {
                using var consumer =
                    new ConsumerBuilder<Ignore, string>(consumerConfig).Build();

                consumer.Subscribe("chat-message");

                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    try
                    {
                        var result = consumer.Consume(cancellationTokenSource.Token);

                        Invoke(() =>
                        {
                            txtMessages.AppendText(
                                "Friend : " +
                                result.Message.Value +
                                Environment.NewLine);
                        });
                    }
                    catch
                    {
                    }
                }

                consumer.Close();
            });
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
                return;

            using var producer =
                new ProducerBuilder<Null, string>(producerConfig).Build();

            await producer.ProduceAsync(
                "chat-message",
                new Message<Null, string>
                {
                    Value = txtMessage.Text
                });

            txtMessages.AppendText(
                "Me : " +
                txtMessage.Text +
                Environment.NewLine);

            txtMessage.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}