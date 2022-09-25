

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkerService;

Console.WriteLine("Hello, World!");

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();
await host.RunAsync();