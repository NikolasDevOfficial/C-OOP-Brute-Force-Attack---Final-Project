using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

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
        }

        private List<PerformanceResult> _results = new List<PerformanceResult>();

   
        public void LogPerformance(string methodName, long attempts, Action action)
        {
            var stopwatch = Stopwatch.StartNew();
            bool success = false;

            try
            {
                action();
                success = true;
            }
            catch
            {
                success = false;
            }
            finally
            {
                stopwatch.Stop();
            }

            _results.Add(new PerformanceResult
            {
                Method = methodName,
                Duration = stopwatch.Elapsed,
                Attempts = attempts,
                Success = success
            });
        }

        public IEnumerable<PerformanceResult> GetResults()
        {
            return _results;
        }

        public void DisplayResults(TextBox textBox)
        {
            textBox.Clear();

            foreach (var result in _results)
            {
                textBox.AppendText(
                    $"{result.Method} - Time: {result.Duration.TotalSeconds:F2}s, " +
                    $"Attempts: {result.Attempts:N0}, " +
                    $"Status: {(result.Success ? "Success" : "Failed")}" +
                    Environment.NewLine
                );
            }
        }
    }
}