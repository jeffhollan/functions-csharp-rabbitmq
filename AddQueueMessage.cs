using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Hollan.Function
{
    public static class AddQueueMessage
    {
        [FunctionName("AddQueueMessage")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            [RabbitMQ(ConnectionStringSetting = "RabbitMqConnection", QueueName = "hello")] out string outputMessage,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            outputMessage = "Hello";
            return new OkResult();
        }
    }
}
