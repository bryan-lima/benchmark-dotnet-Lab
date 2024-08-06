using BenchmarkDotNet.Attributes;

namespace SimpleBenchmarks.Benchmarks
{
    public class FirstBenchmark
    {
        #region Private Fields

        private string _text = "/";

        #endregion Private Fields

        #region Public Methods

        [Benchmark]
        public bool EndsWithBarString()
        {
            return _text.EndsWith("/");
        }

        [Benchmark]
        public bool EndsWithBarChar()
        {
            return _text.EndsWith('/');
        }

        #endregion Public Methods
    }
}
