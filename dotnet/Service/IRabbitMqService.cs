namespace dotnet.Services
{
    public interface IRabbitMqService
    {
        void SendNameToQueue(string name);
    }
}