namespace UnitConversionApi.Services.Interfaces;

public interface IConversionService
{
    double Convert(
        string category,
        string fromUnit,
        string toUnit,
        double value);

    Dictionary<string, List<string>> GetSupportedUnits();
}