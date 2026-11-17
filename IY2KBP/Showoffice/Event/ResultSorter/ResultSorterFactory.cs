using Event.Evaluation;

namespace Event.ResultSorter
{
    public static class ResultSorterFactory
    {
        public static IResultSorter Create(EvaluationType evaluation)
        {
            return evaluation switch
            {
                EvaluationType.FaultTime => new FaultTimeSorter(),
                EvaluationType.IdealTime => new IdealTimeSorter(),
                EvaluationType.Style => new StyleSorter(),
                _ => throw new ArgumentOutOfRangeException(nameof(evaluation))
            };
        }
    }
}
