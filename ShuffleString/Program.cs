using System;
using System.Collections.Generic;

namespace ShuffleString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input1 = "codeleet";
            int[] input2 = new[] {4, 5, 6, 7, 0, 2, 1, 3};
            string output = RestoreString(input1, input2);
            Console.WriteLine(input1);
            Console.WriteLine(output);
        
        public static string RestoreString(string s, int[] indices)
        {
            string aux = "";
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < indices.Length; i++)
            {
                dic.Add(indices[i], s[i].ToString());
            }

            for (int i = 0; i < indices.Length; i++)
            {
                aux += dic[i];
            }
            return aux;
        }
    }
}