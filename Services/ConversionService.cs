using UnitConversionApi.Data;

namespace UnitConversionApi.Services;

public class ConversionService : IConversionService
{
    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        // Length Conversion
        if (UnitDefinitions.LengthUnits.ContainsKey(fromUnit)
            && UnitDefinitions.LengthUnits.ContainsKey(toUnit))
        {
            double meters =
                value * UnitDefinitions.LengthUnits[fromUnit];

            return meters /
                   UnitDefinitions.LengthUnits[toUnit];
        }

        // Weight Conversion
        if (UnitDefinitions.WeightUnits.ContainsKey(fromUnit)
            && UnitDefinitions.WeightUnits.ContainsKey(toUnit))
        {
            double kg =
                value * UnitDefinitions.WeightUnits[fromUnit];

            return kg /
                   UnitDefinitions.WeightUnits[toUnit];
        }

        // Temperature Conversion
        return TemperatureConversion(
            value,
            fromUnit,
            toUnit);
    }

    private double TemperatureConversion(
        double value,
        string fromUnit,
        string toUnit)
    {
        double celsius;

        switch (fromUnit)
        {
            case "celsius":
                celsius = value;
                break;

            case "fahrenheit":
                celsius = (value - 32) * 5 / 9;
                break;

            case "kelvin":
                celsius = value - 273.15;
                break;

            default:
                throw new Exception(
                    "Unsupported unit conversion");
        }

        return toUnit switch
        {
            "celsius" => celsius,
            "fahrenheit" => celsius * 9 / 5 + 32,
            "kelvin" => celsius + 273.15,
            _ => throw new Exception(
                "Unsupported unit conversion")
        };
    }
}