using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        #if NET8_0
            Console.WriteLine("Hi, I am running with version .NET 8.0 code");
        #elif NET6_0
            Console.WriteLine("Hi, I am running with version .NET 6.0 code");
        #else
            Console.WriteLine("Hi, I am running with an unknown version.");
        #endif
                // Get the .NET runtime version
        string runtimeVersion = RuntimeInformation.FrameworkDescription;

        // Output the version
        Console.WriteLine($"Hi, I am running with runtimeversion: {runtimeVersion}");
    }
}