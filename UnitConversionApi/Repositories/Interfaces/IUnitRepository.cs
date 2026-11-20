using UnitConversionApi.Models;

namespace UnitConversionApi.Repositories.Interfaces;

public interface IUnitRepository
{
    List<UnitDefinition> GetUnits();
    Dictionary<string, List<string>> GetSupportedUnits();
}