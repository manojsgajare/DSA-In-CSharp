using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Strings
{
    public class StringGroupAnagrams
    {
        public List<List<string>> Find(string[] words)
        {
            Dictionary<string, string[]> kp = new Dictionary<string, string[]>();

            foreach (string word in words)
            {
                var ch = word.ToCharArray();
                ch.Sort();
                string sortedKey = ch.ToString();

                if(kp.ContainsKey(sortedKey))
                {
                    kp[sortedKey] = new string[];
                }


            }


            return new List<List<string>>();
        }
    }
}
