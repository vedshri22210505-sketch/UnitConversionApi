namespace UnitConversionApi.Data;

public static class UnitDefinitions
{
    public static readonly Dictionary<string, double> LengthUnits =
        new()
        {
            { "meter", 1 },
            { "kilometer", 1000 },
            { "feet", 0.3048 },
            { "inch", 0.0254 }
        };

    public static readonly Dictionary<string, double> WeightUnits =
        new()
        {
            { "kilogram", 1 },
            { "gram", 0.001 },
            { "pound", 0.453592 }
        };
}