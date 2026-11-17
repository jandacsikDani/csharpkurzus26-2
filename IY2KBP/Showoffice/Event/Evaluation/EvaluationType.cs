using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Event.Evaluation;

public enum EvaluationType
{
    [Description("Hiba idő")]
    FaultTime,
    [Description("Ideális idő")]
    IdealTime,
    [Description("Stílus bírálat")]
    Style
}
