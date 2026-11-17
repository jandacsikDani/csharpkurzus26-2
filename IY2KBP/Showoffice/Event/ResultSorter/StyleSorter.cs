using System.ComponentModel;

using Event.Evaluation;

namespace Event.ResultSorter
{
    public class StyleSorter : IResultSorter
    {
        public BindingList<Competitor> Sort(BindingList<Competitor> competitors)
        {
            foreach (var categoryGroup in competitors.GroupBy(x => x.Category))
            {
                var sorted = categoryGroup
                    .OrderByDescending(x => ((StyleResult)x.Result).FinalStyle)
                    .OrderBy(x => x.Result.FaultPoints)
                    .ThenBy(x => x.Result.Time)
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
