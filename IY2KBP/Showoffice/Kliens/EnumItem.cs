using System;
using System.Collections.Generic;
using System.Text;

namespace Kliens;

public class EnumItem<T> where T: Enum
{
    public T Value { get; }
    public string Description { get; }

    public EnumItem(T value)
    { 
        Value = value;
        Description = value.GetDescription();
    }

    public override string ToString()
    {
        return Description;
    }
}
