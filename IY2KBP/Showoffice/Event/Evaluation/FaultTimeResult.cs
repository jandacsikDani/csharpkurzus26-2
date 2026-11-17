using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Event.Evaluation;

internal class FaultTimeResult : EvaluationResult
{
    public override XElement ExportResult()
    {
        return new XElement("result",
            new XElement(nameof(Time), Time),
            new XElement(nameof(FaultPoints), FaultPoints)
        );
    }
}
