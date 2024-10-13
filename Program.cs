class Program
{
    static void Main(string[] args)
    {
        #if NET8_0
            Console.WriteLine("Hi, I am running with version .NET 8.0");
        #elif NET6_0
            Console.WriteLine("Hi, I am running with version .NET 6.0");
        #else
            Console.WriteLine("Hi, I am running with an unknown version.");
        #endif
    }
}