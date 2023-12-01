namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ci tapsiriq
            string name = "Ali";
            string surname = "Nazarov";
            string fullname = name  + surname;
            Console.WriteLine($" Sexsin melumatlari  {fullname} ");
            //2 ci tapsiriq
            int a = 6;
            int b = 7;
            Console.WriteLine($"Ededin cemi : {a+b}");
            //3 cu tapsiriq
            int x = 8;
            int y = 9;
            Console.WriteLine($"Ededin ferqi : {x - y}");
            //4 cu tapsiriq
            int z = 4;
            int v = 5;
            int resultt = z * v;
            Console.WriteLine($"Ededin hasili : {resultt*resultt}");

            //5 ci tapsiriq
            int c = 10;
            int d = 5;
            int result = c/d;
            Console.WriteLine($" Ededin bolmesi : {result*result}");
        }
    }
}
