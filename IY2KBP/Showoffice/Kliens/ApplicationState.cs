using System;
using System.Collections.Generic;
using System.Text;

using Event;

namespace Kliens;

public class ApplicationState
{
    private static readonly ApplicationState _instance = new();
    public static ApplicationState Current => _instance;
    public CompetitionNumber? CompetitionNumber { get; set; } = null;

    private ApplicationState()
    { }
}
