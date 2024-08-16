using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MALRenamer
{
    public class RateLimiter
    {
        private readonly SemaphoreSlim _semaphore;
        private readonly List<DateTime> _requestTimestamps;
        private readonly int _requestsPerSecond;
        private readonly int _requestsPerMinute;

        public RateLimiter(int requestsPerSecond, int requestsPerMinute)
        {
            _requestsPerSecond = requestsPerSecond;
            _requestsPerMinute = requestsPerMinute;
            _semaphore = new SemaphoreSlim(requestsPerSecond, requestsPerSecond);
            _requestTimestamps = new List<DateTime>();
        }

        public async Task DelayIfNeededAsync()
        {
            DateTime now = DateTime.UtcNow;

            lock (_requestTimestamps)
            {
                _requestTimestamps.RemoveAll(timestamp => timestamp < now.AddSeconds(-1));
            }

            if (_requestTimestamps.Count >= _requestsPerMinute)
            {
                DateTime firstRequestTime = _requestTimestamps.First();
                int delayMilliseconds = (int)(firstRequestTime.AddMinutes(1) - now).TotalMilliseconds;
                if (delayMilliseconds > 0)
                {
                    await Task.Delay(delayMilliseconds);
                }
            }

            await Task.Delay(1000 / _requestsPerSecond);
        }
    }
}
