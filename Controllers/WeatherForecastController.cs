using Microsoft.AspNetCore.Mvc;

namespace adapterdesign.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly Iweatherprovider _weatherprovider;
private readonly Itxtweatherprovider _txtweatherprovider;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,  Iweatherprovider weatherprovider,
         Itxtweatherprovider txtweatherprovider
        )
    {
        _logger = logger;
_weatherprovider=weatherprovider;
_txtweatherprovider=txtweatherprovider;
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     // {
    //     //     Date = DateTime.Now.AddDays(index),
    //     //     TemperatureC = Random.Shared.Next(-20, 55),
    //     //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     // })
    //     // .ToArray();

    //     return _weatherprovider.Get();
    // }


    [HttpGet(Name = "GetWeather")]
    public string Get()
    {
        // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        // {
        //     Date = DateTime.Now.AddDays(index),
        //     TemperatureC = Random.Shared.Next(-20, 55),
        //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        // })
        // .ToArray();

        return _txtweatherprovider.Get();
    }


}
