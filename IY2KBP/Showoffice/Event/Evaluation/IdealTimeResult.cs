using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Event.Evaluation;

internal class IdealTimeResult : EvaluationResult
{
    public double IdealTime { get; set; }

    public override XElement ExportResult()
    {
        return new XElement("result",
            new XElement(nameof(Time), Time),
            new XElement(nameof(FaultPoints), FaultPoints),
            new XElement(nameof(IdealTime), IdealTime)
        );
    }
}
