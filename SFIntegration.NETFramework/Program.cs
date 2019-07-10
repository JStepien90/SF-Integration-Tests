using Task = System.Threading.Tasks.Task;

namespace SFIntegration.NETFramework
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await new REST().Test();
        }
    }
}
