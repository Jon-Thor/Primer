namespace Primer { 

    class Program {

        static void Main(string[] args) {
            NumberList();
        }
            

        static void NumberList() {
            List<int>firstlist = new List<int>();
            bool check = true;
            Console.WriteLine("Input number");
            
            do
            {
                Console.Write("Input a number:");
                string input = Console.ReadLine();
                if(input.Trim() == "" && firstlist.Count() >= 1)
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
    }


}
