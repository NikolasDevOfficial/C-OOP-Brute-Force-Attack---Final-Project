using System;

namespace CsharpBruteForceFinal
{
    public class ProgressTracker
    {
        private long _total;
        private long _current;

        private int _lastPercentSent = -1;
        private long _lastSentCount = 0;

        public event Action<long, int> ProgressChanged;

        public ProgressTracker(long total)
        {
            _total = total;
        }

        public void Update()
        {
            _current++;

            int percent = (int)((_current * 100) / _total);
            if (percent > 100) percent = 100;

            if (_current - _lastSentCount >= 330000 || percent != _lastPercentSent)
            {
                _lastSentCount = _current;
                _lastPercentSent = percent;

                ProgressChanged?.Invoke(_current, percent);
            }
        }
    }
}