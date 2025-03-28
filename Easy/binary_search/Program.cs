namespace NeetCode.Easy.binary_search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            var solution = new Solution();
            Console.WriteLine($"{solution.Search(nums, 9)}");
            Console.WriteLine($"{solution.Search(nums, 2)}");
        }
    }
}
