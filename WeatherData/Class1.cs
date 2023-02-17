using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataProject
{
    public class WeatherData
    {
        public WeatherData() { }

        public string Scale { get; set; }
        private int _temperature;
        public int Temperature {
            get { return _temperature; }

            set { 
                if(Scale.ToUpper() == "F")
                {
                    if (value >= -76 && value <= 140) {
                    _temperature  = value; }
                    else
                    {
                        throw new Exception("Must be under 140F° and over -76F°");
                    }

                }
                
                
                
                
                else if (Scale.ToUpper() == "C")
                {
                    if (value >= -60 && value <= 60)
                    {
                        _temperature = value;
                    }else
                    {
                        throw new Exception("Must be under 60C° and over -60C°");
                    }
                }
                else { throw new Exception("Something is wrong"); }
                 } 
        }

        private int _humidity;
        public int Humidity { get {
            return _humidity;
            } set { 
                if(value < 0 || value > 100)
                {
                    throw new Exception("Can't be under 0 or over 100");
                }
                else { _humidity = value; }
                 } }

        public string Input { get; set; }

        public void Convert()
        {
            if(Scale== "F")
            {
                Scale = "C";
                Temperature = (Temperature - 32) * 5 / 9;
            }
            else if (Scale== "C")
            {
                Scale = "F";
                Temperature = (Temperature * 9 / 5) + 32; ;
                
            }
        }
    }
}

