using WeatherDataProject;

WeatherData wd = new WeatherData();

Console.Write("Select Scale F/C:");
wd.Scale = Console.ReadLine().ToUpper();


Console.Write("Input Temp:");
wd.Temperature = int.Parse(Console.ReadLine());
Console.Write("Input Humidity:");
wd.Humidity = int.Parse(Console.ReadLine());

Console.WriteLine($"Temp: {wd.Temperature}{wd.Scale}° -- Scale: {wd.Scale} -- Hum: {wd.Humidity}%");

wd.Convert();
Console.WriteLine("Converted");
Console.WriteLine($"Temp: {wd.Temperature}{wd.Scale}° -- Scale: {wd.Scale} -- Hum: {wd.Humidity}%");