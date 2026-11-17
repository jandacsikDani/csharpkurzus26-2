using System.ComponentModel;

using Event.Evaluation;

namespace Event.ResultSorter
{
    public class IdealTimeSorter : IResultSorter
    {
        public BindingList<Competitor> Sort(BindingList<Competitor> competitors)
        {
            foreach (var categoryGroup in competitors.GroupBy(x => x.Category))
            {
                var sorted = categoryGroup
                    .OrderBy(x => x.Result.FaultPoints)
                    .ThenBy(x => ((IdealTimeResult)x.Result).IdealTime)
                    .ToList();

                int officialPlace = 1;
                foreach (var competitor in sorted)
                {
                    competitor.Placement = officialPlace;
                    officialPlace++;
                }
            }
            return new BindingList<Competitor>(competitors.OrderBy(x => x.Placement).ToList());
        }
    }
}
