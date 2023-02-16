namespace Primer { 

    /*class Program {

        static void Main(string[] args) {
            NumberList();
        }
            

        static void NumberList() {
            List<int>firstlist = new List<int>();
            bool check = true;
            Console.WriteLine("Input number");
            
            do
            {
                Console.Write("Input a number: ");
                string input = Console.ReadLine();
                if(input.Trim() == "")
                {
                    check = false;
                }
                else if(int.TryParse(input, out int value)){
                    firstlist.Add(value);
                }
                else
                {
                    Console.WriteLine("Not a number");
                }
            } while (check);
            firstlist.Sort();
            Console.WriteLine($"{firstlist.First()} is the smallest and {firstlist.Last()} is the largest");
        }
    }*/

    class WeatherData
    {

        static bool Checker(int a, int min, int max)
        {
            return (a >= min && a <= max);
        }
        
        static void Main(string[] args )
        {
            Console.WriteLine("Input Values");
            
            string scale;
            int temperature;
            int humidity;
            string input = "x";
            Console.WriteLine("Select Scale F/C");
            scale = Console.ReadLine().ToUpper();
            Console.WriteLine("Input Temp");
            temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Humidity");
            humidity = int.Parse(Console.ReadLine());

            
            //temperature >= -76 && temperature <= 140

            while (scale != "" && temperature != null && input != "" && input.ToUpper() != "N") { 
            if (scale == "F" && Checker(temperature, -76, 140) && Checker(humidity, 0, 100))
                {
                Console.WriteLine("Do you want to convert");

                Console.WriteLine("Y?/N?");
                input = Console.ReadLine();
                if(input.ToUpper() == "Y")
                {
                    scale = Convert(scale);
                    temperature = Convert(temperature, scale);
                    Console.WriteLine($"Scale: {scale}");
                    Console.WriteLine($"Temperature: {temperature} Celsius");
                    }
                    else if (input.ToUpper() == "N")
                    {
                        Console.WriteLine("Thank you have a nice day");
                        break;
                    }
                } else if (scale == "C" && Checker(temperature , -60, 60) && Checker(humidity, 0, 100))
            {
                Console.WriteLine("Do you want to convert");
                Console.WriteLine("Y?/N?");
                input = Console.ReadLine();
                if (input.ToUpper() == "Y")
                {
                    scale = Convert(scale);
                    temperature = Convert(temperature, scale);
                    Console.WriteLine($"Scale: {scale}");
                    Console.WriteLine($"Temperature: {temperature} Fahrenheit");
                } else if (input.ToUpper() =="N") 
                    {
                        Console.WriteLine("Thank you have a nice day");
                        break;
                    }
            }else
                {
                    Console.WriteLine("Something seems to be wrong please input again");
                    Console.WriteLine("Select Scale F/C");
                    scale = Console.ReadLine().ToUpper();
                    Console.WriteLine("Input Temp");
                    temperature = int.Parse(Console.ReadLine());
                    humidity = int.Parse(Console.ReadLine());
                }
            }

        }
        static int Convert(int temperature, string a)
        {
            if(a == "F")
            {
                temperature = (temperature - 32) * 5/9;
            }else if(a == "C")
            {
                temperature = (temperature * 9/5) +  32;
            }
            return temperature;
        }
        static string Convert(string scale)
        {
            if(scale == "F")
            {
                Console.WriteLine("Converted to Celsius ");
                scale = "C";
            } else if (scale == "C")
            {
                Console.WriteLine("Converted to Fahrenheit");
                scale = "F";
            }
            return scale;
        }
    }
}
