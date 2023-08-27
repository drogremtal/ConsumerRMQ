// See https://aka.ms/new-console-template for more information

using ConsumerRMQ.RabbitMQ;

var service = new RabbitMQConsumer();


service.GetMessage();

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();


