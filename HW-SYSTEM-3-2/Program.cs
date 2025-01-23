namespace HW_SYSTEM_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Fibonacci numbers -----");
            Thread thread = new(Fibonacci);
            thread.Start();

            Console.ReadKey();

        }
        static void Fibonacci()
        {
            List<long> list = new List<long>() { 0, 1 };
            Console.WriteLine($"{list[0]}\n{list[1]}");
            for(int i = 0; ;i++)
            {
                list.Add(list[i] + list[i + 1]);
                Console.WriteLine(list.Last());
                Thread.Sleep(300);
            }

        }
    }
}
