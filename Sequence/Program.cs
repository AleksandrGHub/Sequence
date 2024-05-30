namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 103;
            int summandNumber = 7;
            int minNumber = 5;

            for (int i = minNumber; minNumber <= maxNumber; minNumber += summandNumber)
            {
                Console.WriteLine(minNumber);
            }
        }
    }
}