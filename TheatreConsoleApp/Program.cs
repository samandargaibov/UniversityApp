using Core.Services;
using TheatreConsoleApp.Models;
using TheatreConsoleApp.Services;

namespace TheatreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zalManager = new ZalManager();
            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                if (command.ToLower().Equals("add zal"))
                {
                    var zal1 = new Zal
                    {
                        Id = 1,
                        Name = "Kapital",
                        Column = 10,
                        Row = 10,
                    };

                    var zal2 = new Zal
                    {
                        Id = 2,
                        Name = "Pasha",
                        Column = 5,
                        Row = 5,
                    };

                    var zal3 = new Zal
                    {
                        Id = 3,
                        Name = "Bolkart",
                        Column = 15,
                        Row = 15,
                    };

                    zalManager.Add(zal1);
                    zalManager.Add(zal2);
                    zalManager.Add(zal3);
                }

                else if (command.ToLower().Equals("print zals"))
                {
                    zalManager.Print();
                }

            } while (command.ToLower() != "quit");
        }
    }
}