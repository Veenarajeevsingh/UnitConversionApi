using UnitConversionApi.Repositories;
using UnitConversionApi.Services;

namespace UnitConversionApi.Tests;

public class ConversionServiceTests
{
    [Fact]
    public void Meter_To_Feet_Should_Return_Correct_Result()
    {
       

        var repository = new UnitRepository();

        var service =
            new ConversionService(repository);

        

        var result =
            service.Convert(
                "Length",
                "Meter",
                "Feet",
                1);

        

        Assert.Equal(
            3.28084,
            result,
            5);
    }

    [Fact]
    public void Kilometer_To_Meter_Should_Return_5000()
    {
        

        var repository = new UnitRepository();

        var service =
            new ConversionService(repository);

        

        var result =
            service.Convert(
                "Length",
                "Kilometer",
                "Meter",
                5);

        

        Assert.Equal(
            5000,
            result);
    }
}