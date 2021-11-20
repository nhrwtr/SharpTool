using System;
using System.Diagnostics;

namespace SharpTool.Diagnostics
{
    public class Performance : IDisposable
    {
        private readonly Stopwatch _stopwatch = new();

        public TimeSpan LapTime => _stopwatch.Elapsed;

        public Performance()
        {
            _stopwatch.Start();
        }

        public void Stop()
        {
            _stopwatch.Stop();
        }

        public void Restart()
        {
            _stopwatch.Restart();
        }

#pragma warning disable CA1816 // Dispose メソッドは、SuppressFinalize を呼び出す必要があります
        public void Dispose()
#pragma warning restore CA1816 // Dispose メソッドは、SuppressFinalize を呼び出す必要があります
        {
            _stopwatch.Stop();
            Console.WriteLine($"elapsed time: {_stopwatch.Elapsed.TotalSeconds:0.000}(s), {_stopwatch.Elapsed.TotalMilliseconds:0.000}(ms)");
        }
    }
}
