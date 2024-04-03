namespace Classes_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates greeting object and calls welcome method on object
            Greetings greetings = new Greetings();
            greetings.Welcome();

            //asks user name and prints it to console with hello greeting
            Console.WriteLine("What may your name be?");
            string userName = Console.ReadLine();

            greetings.Hello(userName);
        }
    }
}