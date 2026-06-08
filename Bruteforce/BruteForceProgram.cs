using System;
using System.Diagnostics;
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

        private void Reset()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _foundPassword = null;
        }

        public string StartBruteForce()
        {
            Reset();

            int numThreads = Environment.ProcessorCount - 1;
            if (numThreads < 1) numThreads = 1;

            Debug.WriteLine($"Starting brute force with {numThreads} threads");

            try
            {
                Parallel.For(1, 7, new ParallelOptions
                {
                    MaxDegreeOfParallelism = numThreads,
                    CancellationToken = _cancellationTokenSource.Token
                }, (length, state) =>
                {
                    Debug.WriteLine($"Thread processing length {length}");

                    foreach (var combination in _combinationsGenerator.GenerateCombinations(length))
                    {
                      
                        if (_cancellationTokenSource.Token.IsCancellationRequested)
                        {
                            Debug.WriteLine($"Cancellation was detected > {length}");
                            state.Stop();
                            return;
                        }

                        if (_validator.ValidateCombination(combination))
                        {
                            Debug.WriteLine($"Password found: {combination}");
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
                Debug.WriteLine("Brute force has been canceled");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }

            Debug.WriteLine("Brute force has completed");
            return _foundPassword;
        }
        public string StartBruteForceSingleThread()
        {
            Reset();

            for (int length = 1; length <= 6; length++)
            {
                foreach (var combination in _combinationsGenerator.GenerateCombinations(length))
                {
                    if (_cancellationTokenSource.Token.IsCancellationRequested)
                        return null;

                    _progressTracker.Update();

                    if (_validator.ValidateCombination(combination))
                    {
                        _foundPassword = combination;
                        PasswordFound?.Invoke(combination);
                        return combination;
                    }
                }
            }

            return _foundPassword;
        }
     
        public long GetAttempts()
        {
            return _progressTracker.Current;
        }

        public void StopBruteForce()
        {
            Debug.WriteLine("StopBruteForce was called");
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                Debug.WriteLine("Cancellation was requested");
            }
            else
            {
                Debug.WriteLine("Cancellation is null");
            }
        }
    }
}