using adapterdesign;
using Csv;

public class csvweatherprovider : Itxtweatherprovider
{

    private readonly Iweatherprovider weatherprovider;
    public csvweatherprovider(Iweatherprovider _weatherprovider)
    {
        weatherprovider = _weatherprovider;
    }


    public string Get()
    {
        var headers=new []{"date","tempa"};
        var csv=weatherprovider.Get().Select(w=>new string[]{w.Date.ToString(), w.TemperatureC.ToString()});

        return CsvWriter.WriteToText(headers, csv);
    }
}

  