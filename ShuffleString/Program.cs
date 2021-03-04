using System;
using System.Collections.Generic;

namespace ShuffleString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
        
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