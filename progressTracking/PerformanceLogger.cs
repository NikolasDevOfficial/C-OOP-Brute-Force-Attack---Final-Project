using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CsharpBruteForceFinal.progressTracking
{
    public class PerformanceLogger
    {
        public class PerformanceResult
        {
            public string Method { get; set; }
            public TimeSpan Duration { get; set; }
            public long Attempts { get; set; }
            public bool Success { get; set; }
            public string Password { get; set; }
        }

        private List<PerformanceResult> _results = new List<PerformanceResult>();

        public void LogPerformance(string methodName, Action action, Func<long> getAttempts, Func<string> getPassword)
        {
            var stopwatch = Stopwatch.StartNew();
            bool success = false;
            string password = null;

            try
            {
                action();
                success = true;
                password = getPassword();
            }
            finally
            {
                stopwatch.Stop();
                _results.Add(new PerformanceResult
                {
                    Method = methodName,
                    Duration = stopwatch.Elapsed,
                    Attempts = getAttempts(),
                    Success = success,
                    Password = password
                });
            }
        }

        public void DisplayResults(Label label)
        {
            label.Text = "Performance Results:\n\n";

            foreach (var result in _results)
            {
                label.Text += $"{result.Method}:\n" +
                             $"  Time: {result.Duration.TotalSeconds:F2}s\n" +
                             $"  Attempts: {result.Attempts:N0}\n" +
                             $"  Status: {(result.Success ? "Success" : "Failed")}\n";
                if (result.Success)
                {
                    label.Text += $"  Password: {result.Password}\n";
                }
                label.Text += "\n";
            }

            if (_results.Count >= 2)
            {
                var single = _results.Find(r => r.Method == "Single-thread");
                var multi = _results.Find(r => r.Method == "Multi-thread");

                if (single != null && multi != null && single.Success && multi.Success)
                {
                    double speedup = single.Duration.TotalSeconds / multi.Duration.TotalSeconds;
                    label.Text += $"Comparison:\n" +
                                 $"  Multi-thread was {speedup:F1}x faster\n" +
                                 $"  Time saved: {single.Duration.TotalSeconds - multi.Duration.TotalSeconds:F2}s";
                }
            }
        }
    }
}