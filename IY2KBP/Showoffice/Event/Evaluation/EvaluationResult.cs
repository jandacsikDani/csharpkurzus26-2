using System;
using System.Collections.Generic;
using System.Text;

namespace Event.Evaluation;

public abstract class EvaluationResult
{
    public double Time { get; set; }
    public double FaultPoints { get; set; }
}
