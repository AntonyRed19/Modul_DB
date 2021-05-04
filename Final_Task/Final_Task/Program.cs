using System;
using System.Threading.Tasks;
using EFCoreDemo;
using Final_Task.Services;

namespace Final_Task
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await using (var context = new SampleContextFactory().CreateDbContext(args))
            {
                await new Linq(context).Task3();
            }

            Console.Read();
        }
    }
}
