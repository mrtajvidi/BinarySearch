namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Square root of 26 is: {MySqrt(26)}");
        }

        public static int MySqrt(int x)
        {
            if (x < 2) return x;

            var start = 0;
            var end = x;
            var middle = 0;
            middle = start + (end - start) / 2;

            while (start <= end)
            {
                middle = start + (end - start) / 2;

                var multiplication = (long)middle * middle;
                if (multiplication > x)
                {
                    end = middle - 1;
                }
                else if (multiplication < x)
                {
                    start = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return end;
        }
    }
}
