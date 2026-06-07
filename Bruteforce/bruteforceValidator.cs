using System;
using System.Security.Cryptography;
using System.Text;

namespace CsharpBruteForceFinal
{
    public class BruteForceValidator
    {
        private string _targetHash;

        public BruteForceValidator(string targetHash)
        {
            _targetHash = targetHash;
        }

        public bool ValidateCombination(string combination)
        {
            string hashedCombination = HashCombination(combination);
            return hashedCombination == _targetHash;
        }

        private string HashCombination(string combination)
        {
            byte[] hash = PasswordHashSalt.ComputeSHA256Hash(combination);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }
}