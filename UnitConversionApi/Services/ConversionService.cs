using UnitConversionApi.Repositories.Interfaces;
using UnitConversionApi.Services.Interfaces;

namespace UnitConversionApi.Services;

public class ConversionService : IConversionService
{
    private readonly IUnitRepository _unitRepository;

    public ConversionService(
        IUnitRepository unitRepository)
    {
        _unitRepository = unitRepository;
    }

    public double Convert(
        string category,
        string fromUnit,
        string toUnit,
        double value)
    {
        if (category.Equals("Temperature",
            StringComparison.OrdinalIgnoreCase))
        {
            return ConvertTemperature(
                fromUnit,
                toUnit,
                value);
        }

        var units = _unitRepository.GetUnits();

        var from = units.FirstOrDefault(x =>
            x.Category.Equals(category,
                StringComparison.OrdinalIgnoreCase)
            &&
            x.Name.Equals(fromUnit,
                StringComparison.OrdinalIgnoreCase));

        var to = units.FirstOrDefault(x =>
            x.Category.Equals(category,
                StringComparison.OrdinalIgnoreCase)
            &&
            x.Name.Equals(toUnit,
                StringComparison.OrdinalIgnoreCase));

        if (from == null || to == null)
        {
            return -1;
        }

        double baseValue = value * from.Factor;

        return baseValue / to.Factor;
    }

    public Dictionary<string, List<string>> GetSupportedUnits()
    {
        return _unitRepository.GetSupportedUnits();
    }

    private double ConvertTemperature(
        string fromUnit,
        string toUnit,
        double value)
    {
        if (fromUnit.Equals("Celsius",
            StringComparison.OrdinalIgnoreCase)
            &&
            toUnit.Equals("Fahrenheit",
            StringComparison.OrdinalIgnoreCase))
        {
            return (value * 9 / 5) + 32;
        }

        if (fromUnit.Equals("Fahrenheit",
            StringComparison.OrdinalIgnoreCase)
            &&
            toUnit.Equals("Celsius",
            StringComparison.OrdinalIgnoreCase))
        {
            return (value - 32) * 5 / 9;
        }

        throw new Exception(
            "Temperature conversion not supported");
    }
}