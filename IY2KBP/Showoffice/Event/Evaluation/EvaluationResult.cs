using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Event.Evaluation;

public abstract class EvaluationResult
{
    public double Time { get; set; }
    public double FaultPoints { get; set; }
    public abstract XElement ExportResult();
}
