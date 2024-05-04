using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Vranjes
{
    internal class ZAD4
    {
        public class FindUniqueChars
        {
            public void CharCount(string text)
            {
                var characterCounts = new Dictionary<char, int>();
                foreach (char character in text)
                {
                    if (characterCounts.ContainsKey(character))
                        characterCounts[character]++;
                    else
                        characterCounts.Add(character, 1);
                }
            }
            public List<char> ReturnUniqueChars(Dictionary<char, int> characterCounts)
            {
                List<char> uniqueChars = new List<char>();
                foreach (var chararacter in characterCounts)
                {
                    if (chararacter.Value == 1)
                        uniqueChars.Add(chararacter.Key);
                }
                return uniqueChars;
            }
        }
    }
}
