using Core.Services;
using Microsoft.VisualBasic;
using TheatreConsoleApp.Models;
using TheatreConsoleApp.Services;

namespace TheatreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zalManager = new ZalManager();
            var theatreManager = new TheatreManager();
            var seansManager = new SeansManager();
            var filmManager = new FilmManager();

            string command = "";
            //string addZal = "add zal";

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

                else if (command.ToLower().Equals("add theatre"))
                {
                    var theatre = new Theatre()
                    {
                        Id = 1,
                        Name = "Azerbaijan Cinema",
                        Zals = new Zal[]
                        {
                            (Zal)zalManager.Get(1),
                        },
                        Films = new Film[]
                        {

                            (Film)filmManager.Get(2),
                        },
                        Seans = new Seans[]
                        {
                            (Seans)seansManager.Get(1),
                        }
                        
                    };

                    var theatre1 = new Theatre()
                    {
                        Id = 2,
                        Name = "Deniz Mall Cinema",
                        Zals = new Zal[]
                        {
                            (Zal)zalManager.Get(2),
                        },

                        Films = new Film[]
                        {
                            (Film)filmManager.Get(1),

                        },
                        Seans = new Seans[]
                        {
                            (Seans)seansManager.Get(2),
                        }
                    };

                    theatreManager.Add(theatre);
                    theatreManager.Add(theatre1);
                }

                else if (command.ToLower().Equals("print theatres"))
                {
                    theatreManager.Print();
                }

                else if (command.ToLower().Equals("add film"))
                {
                    var film = new Film()
                    {
                        Id = 1,
                        Name = "Fortuna Operation",
                    };

                    var film1 = new Film()
                    {
                        Id = 2,
                        Name = "Forsaj",
                    };

                    var film2 = new Film()
                    {
                        Id = 3,
                        Name = "Zveropolis",
                    };

                    filmManager.Add(film);
                    filmManager.Add(film1);
                    filmManager.Add(film2);
                }

                else if (command.ToLower().Equals("print films"))
                {
                    filmManager.Print();
                }

                else if (command.ToLower().Equals("add seans"))
                {
                    var seans = new Seans
                    {
                        Id = 1,
                       // Films = new Film[]
                       //{
                       //    (Film)filmManager.Get(1),
                       //},
                       // Zals = new Zal[]
                       //{
                       //    (Zal)zalManager.Get(1),
                       //},
                        SeansTime = DateTime.Parse("1/31/2023 6:00:00 PM"),
                        Price = 8,
                        Theatres = new Theatre[]
                        {
                            (Theatre)theatreManager.Get(1),
                        }
                    };

                    var seans1 = new Seans
                    {
                        Id = 2,
                       // Films = new Film[]
                       //{
                       //    (Film)filmManager.Get(2),
                       //},
                       // Zals = new Zal[]
                       //{
                       //    (Zal)zalManager.Get(2),
                       //},
                        SeansTime = DateTime.Parse("1/31/2023 10:00:00 PM"),
                        Price = 10,
                        Theatres = new Theatre[]
                        {
                            (Theatre)theatreManager.Get(2),
                        }
                    };

                    var seans2 = new Seans
                    {
                        Id = 3,
                       // Films = new Film[]
                       //{
                       //    (Film)filmManager.Get(3),
                       //},
                       // Zals = new Zal[]
                       //{
                       //    (Zal)zalManager.Get(3),
                       //},
                        SeansTime = DateTime.Parse("1/31/2023 8:00:00 PM"),
                        Price = 8,
                        Theatres = new Theatre[]
                        {
                            (Theatre)theatreManager.Get(1),
                        }
                    };

                    seansManager.Add(seans);
                    seansManager.Add(seans1);
                    seansManager.Add(seans2);
                }

                else if (command.ToLower().Equals("print seans"))
                {
                    seansManager.Print();
                }

            } while (command.ToLower() != "quit");
        }
    }
}