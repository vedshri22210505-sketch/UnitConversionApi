using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Models;
using UnitConversionApi.Services;

namespace UnitConversionApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IConversionService _service;

    public ConversionController(
        IConversionService service)
    {
        _service = service;
    }

    [HttpPost("convert")]
    public IActionResult Convert(
        ConversionRequest request)
    {
        try
        {
            var result =
                _service.Convert(
                    request.Value,
                    request.FromUnit,
                    request.ToUnit);

            return Ok(new ConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedValue = result
            });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}