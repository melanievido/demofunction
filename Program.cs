using Microsoft.Extensions.Hosting;
using Microsoft.Azure.Functions.Worker;

namespace demo_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionsDebugger.Enable();

            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .Build();

            host.Run();
        }
    }
}
