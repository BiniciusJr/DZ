using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Vranjes.Refaktoriranje
{
    internal class ZAD5
    {
        public class PalindromeFinder
        {
            public List<string> FindPalindromes(List<string> strings)
            {
                if (strings == null)
                    return new List<string>();

                List<string> palindromes = new List<string>();
                foreach (string str in strings)
                {
                    if (IsPalindrome(str))
                        palindromes.Add(str);
                }
                return palindromes;
            }
            private bool IsPalindrome(string text)
            {
                string altered = ReplaceSpaceAndToLower(text);
                string reversed = ReverseString(altered);
                return reversed==altered;
            }
            private string ReplaceSpaceAndToLower(string text)
            {
                return text.Replace(" ", "").ToLower();
            }
            private string ReverseString(string text)
            {
                return new string(text.Reverse().ToArray());
            }
        }
    }
}
