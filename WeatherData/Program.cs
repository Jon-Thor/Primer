﻿using WeatherDataProject;

/*namespace WeatherDataPrimer
{
    class NotWeatherData
    {

        static bool Checker(int a, int min, int max)
        {
            return (a >= min && a <= max);
        }

        static void Main(string[] args)
        {

            
            Console.Write("Input Temp:");
            
            Console.Write("Input Humidity:");
            humidity = Console.ReadLine();


            while (scale != "" && input != "" && input.ToUpper() != "N")
            {



                if (scale == "F" && int.TryParse(temperature, out tempnum) && Checker(tempnum, min: -76, max: 140) && int.TryParse(humidity, out humNum) && Checker(humNum, min: 0, max: 100))
                {
                    Console.WriteLine("Do you want to convert");

                    Console.WriteLine("Y?/N?");
                    input = Console.ReadLine();
                    if (input.ToUpper() == "Y")
                    {
                        scale = Convert(scale);
                        tempnum = Convert(tempnum, scale);
                        Console.WriteLine($"Temperature: {tempnum}{scale}° and {humidity}% humidity");
                    }
                    else if (input.ToUpper() == "N")
                    {
                        Console.WriteLine("Thank you have a nice day");
                        break;
                    }

                }
                else if (scale == "C" && int.TryParse(temperature, out tempnum) && Checker(tempnum, min: -60, max: 60) && int.TryParse(humidity, out humNum) && Checker(humNum, min: 0, max: 100))
                {
                    Console.WriteLine("Do you want to convert");
                    Console.WriteLine("Y?/N?");
                    input = Console.ReadLine();
                    if (input.ToUpper() == "Y")
                    {
                        scale = Convert(scale);
                        tempnum = Convert(tempnum, scale);
                        Console.WriteLine($"Temperature: {temperature}{scale}° and {humidity}% humidity");
                    }
                    else if (input.ToUpper() == "N")
                    {
                        Console.WriteLine("Thank you have a nice day");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Something seems to be wrong please input again");
                    Console.Write("Select Scale F/C:");
                    scale = Console.ReadLine().ToUpper();
                    Console.Write("Input Temp:");
                    temperature = Console.ReadLine();
                    Console.Write("Input Humidity:");
                    humidity = Console.ReadLine();
                }
            }

        }
        static int Convert(int temperature, string a)
        {
            if (a == "F")
            {
                temperature = (temperature * 9 / 5) + 32;
            }
            else if (a == "C")
            {
                temperature = (temperature - 32) * 5 / 9;
                
            }
            return temperature;
        }
        static string Convert(string scale)
        {
            if (scale == "F")
            {
                Console.WriteLine("Converted to Celsius ");
                scale = "C";
            }
            else if (scale == "C")
            {
                Console.WriteLine("Converted to Fahrenheit");
                scale = "F";
            }
            return scale;
        }
    }
}*/

WeatherData wd = new WeatherData();

Console.Write("Select Scale F/C:");
wd.Scale = Console.ReadLine().ToUpper();


Console.Write("Input Temp:");
wd.Temperature = int.Parse(Console.ReadLine());
Console.Write("Input Humidity:");
wd.Humidity = int.Parse(Console.ReadLine());

Console.WriteLine($"Temp: {wd.Temperature} -- Scale: {wd.Scale} -- Hum: {wd.Humidity}%");

wd.Convert();
Console.WriteLine("Converted");
Console.WriteLine($"Temp: {wd.Temperature} -- Scale: {wd.Scale} -- Hum: {wd.Humidity}%");