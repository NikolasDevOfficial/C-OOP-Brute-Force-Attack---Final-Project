using System;
using System.Collections.Generic;

namespace CsharpBruteForceFinal
{
    public class BruteForceGenerateCombinations
    {
        private string _chars;
        public int CharCount => _chars.Length;
        public BruteForceGenerateCombinations(string chars)
        {
            _chars = chars;
        }

        public IEnumerable<string> GenerateCombinations(int length)
        {
            if (length == 0)

            {
                yield return "";
            }

            else
            {
                foreach (var combination in GenerateCombinations(length - 1))
                {

                    foreach (char c in _chars)

                    {
                        yield return combination + c;
                    }

                }
            }
        }
    }
}