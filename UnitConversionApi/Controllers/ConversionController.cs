using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Models;
using UnitConversionApi.Services.Interfaces;

namespace UnitConversionApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IConversionService _conversionService;

    public ConversionController(
        IConversionService conversionService)
    {
        _conversionService = conversionService;
    }

    [HttpPost]
    public IActionResult Convert(
        ConversionRequest request)
    {
        var result = _conversionService.Convert(
            request.Category,
            request.FromUnit,
            request.ToUnit,
            request.Value);

        if (result == -1)
        {
            return BadRequest(new
            {
                Success = false,
                Message = "Invalid category or unit. Please use GET /api/Conversion/units to view supported units."
            });
        }

        return Ok(new ConversionResponse
        {
            InputValue = request.Value,
            FromUnit = request.FromUnit,
            ToUnit = request.ToUnit,
            ConvertedValue = result
        });
    }

    [HttpGet("units")]
    public IActionResult GetSupportedUnits()
    {
        var units = _conversionService.GetSupportedUnits();

        return Ok(units);
    }
}