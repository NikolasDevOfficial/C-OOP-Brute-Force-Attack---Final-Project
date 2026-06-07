using System;

namespace CsharpBruteForceFinal
{
    public class BruteForceProgram
    {
        private BruteForceGenerateCombinations _combinationsGenerator;
        private BruteForceValidator _validator;
        private ProgressTracker _progressTracker;

        public event Action<string> PasswordFound;

        public ProgressTracker ProgressTracker => _progressTracker;

        public BruteForceProgram(string chars, string targetHash)
        {
            _combinationsGenerator = new BruteForceGenerateCombinations(chars);
            _validator = new BruteForceValidator(targetHash);

            long total = 0;
            for (int i = 1; i <= 6; i++)
            {
                total += (long)Math.Pow(_combinationsGenerator.CharCount, i);
            }

            _progressTracker = new ProgressTracker(total);
        }

        public string StartBruteForce()
        {
            long attempts = 0;

            for (int length = 1; length <= 6; length++)
            {
                foreach (var combination in _combinationsGenerator.GenerateCombinations(length))
                {
                    attempts++;

                    _progressTracker.Update();
                    if (attempts % 100000 == 0) //V1 : Edit: Added separate, To be Fixed
                    {
                        _progressTracker.Update();
                    }
                    if (_validator.ValidateCombination(combination))
                    {
                        PasswordFound?.Invoke(combination);
                        return combination;
                    }
                }
            }

            return null;
        }

        public void StopBruteForce()
        {
            // later
        }
    }
}