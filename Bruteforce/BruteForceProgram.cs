using System;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpBruteForceFinal
{
    public class BruteForceProgram
    {
        private BruteForceGenerateCombinations _combinationsGenerator;
        private BruteForceValidator _validator;
        private CancellationTokenSource _cancellationTokenSource;
        private ProgressTracker _progressTracker;
        private string _foundPassword;



        public event Action<string> PasswordFound;
        public ProgressTracker ProgressTracker => _progressTracker;

        public BruteForceProgram(string chars, string targetHash)
        {
            _combinationsGenerator = new BruteForceGenerateCombinations(chars);
            _validator = new BruteForceValidator(targetHash);

        
            long total = 0;
            for (int length = 1; length <= 6; length++)
            {
                total += (long)Math.Pow(_combinationsGenerator.CharCount, length);
            }

            _progressTracker = new ProgressTracker(total);
        }

        public string StartBruteForce()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _foundPassword = null;

            int numThreads = Environment.ProcessorCount - 1;
            if (numThreads < 1) numThreads = 1;

            try
            {
                Parallel.For(1, 7, new ParallelOptions
                {
                    MaxDegreeOfParallelism = numThreads,
                    CancellationToken = _cancellationTokenSource.Token
                }, (length, state) =>
                {
                    var combinations = _combinationsGenerator.GenerateCombinations(length);
                    foreach (var combination in combinations)
                    {
                        if (_cancellationTokenSource.Token.IsCancellationRequested)
                        {
                            state.Stop();
                            return;
                        }

                        if (_validator.ValidateCombination(combination))
                        {

                            Interlocked.CompareExchange(ref _foundPassword, combination, null);
                            PasswordFound?.Invoke(combination);
                            _cancellationTokenSource.Cancel();
                            state.Stop();
                            return;
                        }

                   
                        _progressTracker.Update();
                    }
                });
            }
            catch (OperationCanceledException)
            {
              
            }

            return _foundPassword;
        }

        public void StopBruteForce()
        {
            _cancellationTokenSource?.Cancel();
        }
    }
}