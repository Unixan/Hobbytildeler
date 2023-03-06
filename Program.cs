namespace Hobbytildeler
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hvem vil ha en ny hobby?");
            var name = Convert.ToString(Console.ReadLine());
            Random number = new();
            int randomNumber = number.Next(4);
            switch (randomNumber)
            {
                case 0:
                    Console.WriteLine($"{name} har begynt å strikke!");
                    break;
                case 1:
                    Console.WriteLine($"{name} har begynt å bake!");
                    break;
                case 2:
                    Console.WriteLine($"{name} har kjøpt seg modelltog!");
                    break;
                case 3:
                    Console.WriteLine($"{name} har begynt å kode!");
                    break;
                default:
                    Console.WriteLine($"{name} har begynt å trene!");
                    break;
            }

        }
    }
}