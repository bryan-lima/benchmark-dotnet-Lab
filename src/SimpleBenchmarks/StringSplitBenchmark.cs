using BenchmarkDotNet.Attributes;

namespace SimpleBenchmarks
{
    [MemoryDiagnoser]
    public class StringSplitBenchmark
    {
        #region Private Fields

        private readonly string _text = "1234-2024";

        #endregion Private Fields

        #region Public Methods

        [Benchmark(Baseline = true)]
        public string[] SplitWithHyphenChar()
        {
            return _text.Split('-');
        }

        [Benchmark]
        public string[] SplitWithHyphenString()
        {
            return _text.Split("-");
        }

        #endregion Public Methods
    }
}
