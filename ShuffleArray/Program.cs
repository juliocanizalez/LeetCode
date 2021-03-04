namespace ShuffleArray
{
    internal class Program
    {
        /*Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

        Return the array in the form [x1,y1,x2,y2,...,xn,yn].*/
        
        public static void Main(string[] args)
        {
            
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