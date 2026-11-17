using System.ComponentModel;

namespace Event.ResultSorter
{
    public interface IResultSorter
    {
        BindingList<Competitor> Sort(BindingList<Competitor> competitors);
    }
}
