using System.ComponentModel;
using System.Reflection;

namespace Kliens;

public static class EnumExtensions
{
    public static string GetDescription<T>(this T value) where T : Enum
    { 
        FieldInfo? field = typeof(T).GetField(value.ToString());
        DescriptionAttribute? attribute = field?.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description ?? value.ToString();
    }
}
