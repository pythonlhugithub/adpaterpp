using adapterdesign;

public class txtweatherprovider : Itxtweatherprovider
{

    private readonly Iweatherprovider weatherprovider;
    public txtweatherprovider(Iweatherprovider _weatherprovider)
    {
        weatherprovider = _weatherprovider;
    }


    public string Get()
    {
        return string.Join(Environment.NewLine, weatherprovider.Get().Select(w => $"{w.Date}|{w.TemperatureC}"));
    }
}

public interface Itxtweatherprovider
{
    string Get();
}

 //--data source

 //--can be adapter by others

 