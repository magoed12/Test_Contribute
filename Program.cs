namespace test
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TempConvert T = new TempConvert();
            Console.WriteLine($"Celcius = {T.C} Farenheit = {T.F}");
            double answer = (32 - T.F) * (5.0 / 9.0);
            Console.WriteLine($"F = {T.F}, C = {answer}");
        }
    }
    class TempConvert
    {
        public double C = 0.0;
        public double F = 32;
    }
}