using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }


    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var today = _date.Now;
        return $"{today:yyyy}" + "." + $"{today:MM}" + "." + $"{today:dd}";
    }

    public string Number03()
    {
        var today = _date.Now;
        return "Day " + $"{today:dd}" + " of " + $"{today:MMMM}" + ", " + $"{today:yyyy}";
    }

    public string Number04()
    {
        var today = _date.Now;
        return "Year: " + $"{today:yyyy}" + ", Month: " + $"{today:MM}" + ", Day: " + $"{today:dd}";
    }

    public string Number05()
    {
        var today = _date.Now;
        return $"{today,17:dddd}";
    }

    public string Number06()
    {
        var today = _date.Now;
        return $"{today,10:t}" + $"{today,10:dddd}";
    }

    public string Number07()
    {
        var today = _date.Now;
        return "h:" + $"{today:hh}" + ", m:" + $"{today:mm}" + ", s:" + $"{today:ss}";
    }

    public string Number08()
    {
        var today = _date.Now;
        return $"{today:yyyy}" + "." + $"{today:MM}" + "." + $"{today:dd}" + "." + $"{today:hh}" + "." + $"{today:mm}" + "." + $"{today:ss}";
    }

    public string Number09()
    {
        var pi = Math.PI;
        return $"{pi,14:n3}";
    }

    public string Number10()
    {
        var pi = Math.PI;
        return $"{pi:C2}";
    }

    public string Number11()
    {
        var today = _date.Now;
        return $"{today.Year:7E7}";
    }

    //2.2019.01.22
}
