using System;
using System.Collections.Generic;
using System.Text;

namespace Event.Evaluation;

internal class StyleResult : EvaluationResult
{
    public double Style { get; set; }
    public double StyleDeduction { get; set; }
    public double FinalStyle => Style - StyleDeduction;
}
