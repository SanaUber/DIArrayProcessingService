using DIArrayProcessingService.Model;

namespace DIArrayProcessingService.Services
{
    public class NumberArrayServices:INumberArrayServices
        // all func needs to be implemeted necessarily
    {
        public int[] SortInLoop(int[] numbers)
        {
            int n = numbers.Length;
            int[] sortedNumbers = (int[])numbers.Clone(); // Clone to avoid modifying the original array

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedNumbers[j] > sortedNumbers[j + 1])
                    {
                        // Swap
                        int temp = sortedNumbers[j];
                        sortedNumbers[j] = sortedNumbers[j + 1];
                        sortedNumbers[j + 1] = temp;
                    }
                }
            }
            return sortedNumbers;
        }

        // Sorting outside a loop (Using LINQ OrderBy)
        public int[] SortOutsideLoop(int[] numbers)
        {
            return numbers.OrderBy(x => x).ToArray(); // Simple built-in sorting
        }
    }
}