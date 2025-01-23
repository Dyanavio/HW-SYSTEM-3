namespace HW_SYSTEM_3
{
    internal class Program
    {
        static int? lower = null;
        static int? upper = null;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the lower and the upper boundaries");
                Console.Write("Lower: ");
                lower = Convert.ToInt32(Console.ReadLine());
                Console.Write("Upper (0 for infinity): ");
                upper = Convert.ToInt32(Console.ReadLine());

                if (lower < 0 || upper < 0) throw new Exception("Boundaries can't be negative");

                Thread thread = new Thread(OutputAllPrimes);
                thread.Start();
               
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ResetColor();
            }
        }
        static void OutputAllPrimes()
        {
            if (lower == null) lower = 2;
            if (upper != 0)
            {
                for(int? i = lower; i < upper; i++)
                {
                    if (IsPrime(i)) Console.WriteLine(i);
                    Thread.Sleep(200);
                }
            }
            else
            {
                for(int? i = lower; ;i++)
                {
                    if (IsPrime(i)) Console.WriteLine(i);
                    Thread.Sleep(200);
                }
            }
        }
        static bool IsPrime(int? number)
        {
            bool flag = true;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
