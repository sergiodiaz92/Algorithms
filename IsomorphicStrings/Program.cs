using System;
using System.Collections.Generic;
using System.Linq;

namespace IsomorphicStrings
{
    class Program
    {
        public static bool AreIsomorphicString(string a, string b)
        {
            bool ret = false;
            if (a.Length != b.Length)
            {
                return ret;
            }
            Dictionary<char, int> dictA = new Dictionary<char, int>();
            Dictionary<char, int> dictB = new Dictionary<char, int>();
            foreach (char c in a)
            {
                if (dictA.ContainsKey(c))
                {
                    dictA[c]++;
                }
                else
                {
                    dictA[c] = 1;
                }
            }
            foreach (char c in b)
            {
                if (dictB.ContainsKey(c))
                {
                    dictB[c]++;
                }
                else
                {
                    dictB[c] = 1;
                }
            }
            
            ret = dictA.Values.OrderBy(k => k).SequenceEqual(dictB.Values.OrderBy(k => k));
            return ret;
        }
        
        public static bool AreExactIsomorphicString(string a, string b)
        {
            bool ret = false;
            if (a.Length != b.Length)
            {
                return ret;
            }
            Dictionary<char, int> dictA = new Dictionary<char, int>();
            Dictionary<char, int> dictB = new Dictionary<char, int>();
            foreach (char c in a)
            {
                if (dictA.ContainsKey(c))
                {
                    dictA[c]++;
                }
                else
                {
                    dictA[c] = 1;
                }
            }
            foreach (char c in b)
            {
                if (dictB.ContainsKey(c))
                {
                    dictB[c]++;
                }
                else
                {
                    dictB[c] = 1;
                }
            }
            
            ret = dictA.Values.SequenceEqual(dictB.Values);
            return ret;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("Are {0} & {1} isomorphic strings? {2}", "appreciations", "astonishingly", AreIsomorphicString("appreciations", "astonishingly")));
            Console.WriteLine(String.Format("Are {0} & {1} isomorphic strings? {2}", "wonderfulness", "astonishingly", AreIsomorphicString("wonderfulness", "astonishingly")));
            Console.WriteLine(String.Format("Are {0} & {1} isomorphic strings? {2}", "probability", "overwriting", AreIsomorphicString("probability", "overwriting")));
            Console.WriteLine(String.Format("Are {0} & {1} isomorphic strings? {2}", "probabilities", "overwriting", AreIsomorphicString("probabilities", "overwriting")));
            Console.WriteLine(String.Format("Are {0} & {1} isomorphic strings? {2}", "probability", "overwritten", AreIsomorphicString("probability", "overwritten")));

            Console.WriteLine();            

            Console.WriteLine(String.Format("Are {0} & {1} exact isomorphic strings? {2}", "appreciations", "astonishingly", AreExactIsomorphicString("appreciations", "astonishingly")));
            Console.WriteLine(String.Format("Are {0} & {1} exact isomorphic strings? {2}", "wonderfulness", "astonishingly", AreExactIsomorphicString("wonderfulness", "astonishingly")));
            Console.WriteLine(String.Format("Are {0} & {1} exact isomorphic strings? {2}", "probability", "overwriting", AreExactIsomorphicString("probability", "overwriting")));
            Console.WriteLine(String.Format("Are {0} & {1} exact isomorphic strings? {2}", "probabilities", "overwriting", AreExactIsomorphicString("probabilities", "overwriting")));
            Console.WriteLine(String.Format("Are {0} & {1} exact isomorphic strings? {2}", "probability", "overwritten", AreExactIsomorphicString("probability", "overwritten")));
        }
    }
}
