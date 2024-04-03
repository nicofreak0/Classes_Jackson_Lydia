namespace Classes_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings greetings = new Greetings();
            greetings.Welcome();

            Console.WriteLine("What may your name be?");
            string userName = Console.ReadLine();

            greetings.Hello(userName);
        }
    }
}