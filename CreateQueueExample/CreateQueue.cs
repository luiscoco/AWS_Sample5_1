namespace CreateQueueExample
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Amazon.SQS;
    using Amazon.SQS.Model;

    public class CreateQueue
    {
        public static async Task Main()
        {
            var client = new AmazonSQSClient();

            string queueName = "New-Example-Queue";
            int maxMessage = 256 * 1024;
            var attrs = new Dictionary<string, string>
            {
                {
                    QueueAttributeName.DelaySeconds,
                    TimeSpan.FromSeconds(5).TotalSeconds.ToString()
                },
                {
                    QueueAttributeName.MaximumMessageSize,
                    maxMessage.ToString()
                },
                {
                    QueueAttributeName.MessageRetentionPeriod,
                    TimeSpan.FromDays(4).TotalSeconds.ToString()
                },
                {
                    QueueAttributeName.ReceiveMessageWaitTimeSeconds,
                    TimeSpan.FromSeconds(5).TotalSeconds.ToString()
                },
                {
                    QueueAttributeName.VisibilityTimeout,
                    TimeSpan.FromHours(12).TotalSeconds.ToString()
                },
            };

            var request = new CreateQueueRequest
            {
                Attributes = attrs,
                QueueName = queueName,
            };

            var response = await client.CreateQueueAsync(request);

            if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Successfully created Amazon SQS queue.");
                Console.WriteLine($"Queue URL: {response.QueueUrl}");
            }
        }
    }
}
