using System;
using System.Collections.Generic;
using System.Linq;

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
            if (length <= 0)
                yield break;

            char[] chars = _chars.ToCharArray();

            var allCombinations = Enumerable.Range(1, length)
                .SelectMany(currentLength =>
                    Enumerable.Repeat(chars, currentLength)
                        .CartesianProduct()
                        .Select(chars => new string(chars.ToArray()))
                );

            foreach (var combination in allCombinations)
            {
                yield return combination;
            }
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> CartesianProduct<T>(this IEnumerable<IEnumerable<T>> sequences)
        {
            IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
            return sequences.Aggregate(
                emptyProduct,
                (accumulator, sequence) =>
                    from accseq in accumulator
                    from item in sequence
                    select accseq.Concat(new[] { item }));
        }
    }
}