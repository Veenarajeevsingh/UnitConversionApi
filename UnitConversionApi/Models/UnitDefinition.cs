namespace UnitConversionApi.Models;

public class UnitDefinition
{
    public string Category { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public double Factor { get; set; }
}