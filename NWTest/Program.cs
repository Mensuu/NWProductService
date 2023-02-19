namespace NWTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    static async Task Categories()
    {
        using (var httpClient = new HttpClient())
        {
            using (var response = await HttpClient.GetAsync("http://localhost:8043/api/satis/Product/GetCat"))
        }
        
    }
}