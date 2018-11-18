namespace Loppemarked
{
    // Main method to run the system
    // Singleton design pattern
    class Program
    {
        static void Main(string[] args)
        {
            Client.StartMarked(); // Press "Enter" to initiate. 
            Client.Exit(); // Press "Space" to exit. 
        }
    }
}
