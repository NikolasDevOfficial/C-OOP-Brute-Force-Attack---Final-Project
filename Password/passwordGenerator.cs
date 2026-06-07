using System;
using System.ComponentModel.DataAnnotations;

namespace CsharpBruteForceFinal
{
    public class passwordGenerator
    {
        private Random random = new Random();

        private string Generate(string chars)
        {
            int passRange = random.Next(4, 7);
            var stringChars = new char[passRange];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }

        public string RandomPasswordGeneratorLowercaseOnly()
        {
            return Generate("abcdefghijklmnopqrstuvwxyz");
        }

        public string RandomPasswordGeneratorLowerUppercase()
        {
            return Generate("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
        }

        public string RandomPasswordGeneratorLowerUpperNumbers()
        {
            return Generate("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890");
        }

        public string RandomPasswordGeneratorLowerUpperNumSymbols()
        {
            return Generate("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890~!@#$%^&*()_+=-/");
        }
    }
}