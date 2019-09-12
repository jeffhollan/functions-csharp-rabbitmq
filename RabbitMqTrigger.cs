using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Hollan.Function
{
    public static class RabbitMqTrigger
    {
        [FunctionName("RabbitMqTrigger")]
        public static void Run([RabbitMQTrigger(connectionStringSetting: "RabbitMqConnection", queueName: "hello")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
