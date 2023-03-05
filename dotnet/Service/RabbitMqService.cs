using System.Text;
using dotnet.Services;
using RabbitMQ.Client;

namespace dotnet.Services
{
    public class RabbitMqService : IRabbitMqService
    {
        public void SendNameToQueue(string name)
        {           
            var factory = new ConnectionFactory() { HostName = "localhost", UserName = "mertcan", Password = "root" };          
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {                
                channel.QueueDeclare(queue: "NameQueue",
                    durable: false,
                    exclusive: false,
                    autoDelete: false, 
                    arguments: null);        
                          
                var body = Encoding.UTF8.GetBytes(name);
                
                channel.BasicPublish(exchange: "",
                    routingKey: "NameQueue", 
                    body: body);
            }
        }
    }
}