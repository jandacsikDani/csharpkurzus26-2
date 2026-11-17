using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;

namespace Event.Evaluation;

internal class StyleResult : EvaluationResult
{
    public double Style { get; set; }
    public double StyleDeduction { get; set; }
    public double FinalStyle => Style - StyleDeduction;

    public override XElement ExportResult()
    {
        return new XElement("result", 
            new XElement(nameof(Time), Time),
            new XElement(nameof(FaultPoints), FaultPoints),
            new XElement(nameof(Style), Style),
            new XElement(nameof(StyleDeduction), StyleDeduction),
            new XElement(nameof(FinalStyle), FinalStyle)
        );
    }
}
