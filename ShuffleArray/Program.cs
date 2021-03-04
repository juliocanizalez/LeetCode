namespace ShuffleArray
{
    internal class Program
    {
        /*Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

        Return the array in the form [x1,y1,x2,y2,...,xn,yn].*/
        
        public static void Main(string[] args)
        {
            int n = 3;
            int[] test = new[] {2, 5, 1, 3, 4, 7};
            int[] result = Shuffle(test, n);
            string input = "", output = "";
            for (int i = 0; i < test.Length; i++)
            {
                input += $"{test[i]}, {n}";
                output += $"{result[i]} ";
            }
            Console.WriteLine(input);
            Console.WriteLine(output);
        }
        
        public static int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];
            int aux = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    result[i] = nums[n];
                    n++;
                }
                else
                {
                    result[i] = nums[aux];
                    aux++;
                }
            }

            return result;
        }
    }
}