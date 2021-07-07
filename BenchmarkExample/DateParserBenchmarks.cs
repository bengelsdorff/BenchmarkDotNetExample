using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkExample
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        private const string DateTime = "2021-07-05T13:33:06Z";
        private static readonly DateParser Parser = new DateParser();

        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDateTime(DateTime);
        }
        
        [Benchmark]
        public void GetYearFromSplit()
        {
            Parser.GetYearFromSplit(DateTime);
        }
        
        [Benchmark]
        public void GetYearFromSubstring()
        {
            Parser.GetYearFromSubstring(DateTime);
        }
        
        [Benchmark]
        public void GetYearFromSpan()
        {
            Parser.GetYearFromSpan(DateTime);
        }
        
    }
}