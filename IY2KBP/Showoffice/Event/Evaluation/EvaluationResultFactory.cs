using System;
using System.Collections.Generic;
using System.Text;

namespace Event.Evaluation;

internal static class EvaluationResultFactory
{
    public static EvaluationResult Create(EvaluationType type)
    {
        return type switch
        {
            EvaluationType.FaultTime => new FaultTimeResult(),
            EvaluationType.IdealTime => new IdealTimeResult(),
            EvaluationType.Style => new StyleResult(),
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };
    }
}
