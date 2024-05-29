namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 103;
            int summandNumber = 7;

            for (int minNumber = 5; minNumber <= maxNumber; minNumber += summandNumber)
            {
                Console.WriteLine(minNumber);
            }
        }
    }
}