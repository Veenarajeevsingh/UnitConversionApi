using UnitConversionApi.Models;
using UnitConversionApi.Repositories.Interfaces;

namespace UnitConversionApi.Repositories;

public class UnitRepository : IUnitRepository
{
    public List<UnitDefinition> GetUnits()
    {
        return new List<UnitDefinition>
        {
            // Length

            new()
            {
                Category = "Length",
                Name = "Meter",
                Factor = 1
            },

            new()
            {
                Category = "Length",
                Name = "Kilometer",
                Factor = 1000
            },

            new()
            {
                Category = "Length",
                Name = "Centimeter",
                Factor = 0.01
            },

            new()
            {
                Category = "Length",
                Name = "Feet",
                Factor = 0.3048
            },

            // Weight

            new()
            {
                Category = "Weight",
                Name = "Kilogram",
                Factor = 1
            },

            new()
            {
                Category = "Weight",
                Name = "Gram",
                Factor = 0.001
            },

            new()
            {
                Category = "Weight",
                Name = "Pound",
                Factor = 0.453592
            }
        };
    }

    public Dictionary<string, List<string>> GetSupportedUnits()
    {
        return new Dictionary<string, List<string>>
        {
            {
                "Length",
                new List<string>
                {
                    "Meter",
                    "Kilometer",
                    "Centimeter",
                    "Feet"
                }
            },
            {
                "Weight",
                new List<string>
                {
                    "Kilogram",
                    "Gram",
                    "Pound"
                }
            },
            {
                "Temperature",
                new List<string>
                {
                    "Celsius",
                    "Fahrenheit"
                }
            }
        };
    }
}