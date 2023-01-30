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
            Console.Title = "Cinema APP";

            var zalManager = new ZalManager();
            var theatreManager = new TheatreManager();
            var seansManager = new SeansManager();
            var filmManager = new FilmManager();
            var ticketManager = new TicketManager();

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
                        ColumnCount = 9,
                        RowCount = 7,
                        Theatre = (Theatre)theatreManager.Get(1),
                    };

                    var zal2 = new Zal
                    {
                        Id = 2,
                        Name = "Pasha",
                        ColumnCount = 5,
                        RowCount = 5,
                        Theatre = (Theatre)theatreManager.Get(2),
                    };

                    var zal3 = new Zal
                    {
                        Id = 3,
                        Name = "Bolkart",
                        ColumnCount = 8,
                        RowCount = 8,
                        Theatre = (Theatre)theatreManager.Get(1),
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
                        
                    };

                    var theatre1 = new Theatre()
                    {
                        Id = 2,
                        Name = "Deniz Mall Cinema",
                      
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
                        Film = (Film)filmManager.Get(1),
                        Zal = (Zal)zalManager.Get(1),
                        SeansTime = DateTime.Parse("1/31/2023 6:00:00 PM"),
                        Price = 8,
                    };

                    var seans1 = new Seans
                    {
                        Id = 2,
                        Film = (Film)filmManager.Get(2),
                        Zal = (Zal)zalManager.Get(2),
                        SeansTime = DateTime.Parse("1/31/2023 10:00:00 PM"),
                        Price = 10,
                    };

                    var seans2 = new Seans
                    {
                        Id = 3,
                        Film = (Film)filmManager.Get(3),
                        Zal = (Zal)zalManager.Get(3),
                        SeansTime = DateTime.Parse("1/31/2023 8:00:00 PM"),
                        Price = 8,
                    };

                    seansManager.Add(seans);
                    seansManager.Add(seans1);
                    seansManager.Add(seans2);
                }

                else if (command.ToLower().Equals("print seans"))
                {
                    seansManager.Print();

                    Console.WriteLine("1.Select Seans:");
                    Console.WriteLine("2.Back: ");

                    int operation = int.Parse(Console.ReadLine());
                    bool seansCheck = false;

                    switch (operation)
                    {
                        case 1:
                            seansCheck = true;

                            Console.Write("Seans ID-ni qeyd edin: ");
                            var id = int.Parse(Console.ReadLine());

                            var seans = (Seans)seansManager.Get(id);
                            var tickets = ticketManager._ticket;

                            Console.WriteLine("");
                            Console.Write("  ");

                            for (int i = 0; i < seans.Zal.ColumnCount; i++)
                            {
                                Console.Write((i + 1) + " ");
                            }

                            Console.WriteLine("");

                            for (int i = 0; i < seans.Zal.RowCount; i++)
                            {
                                Console.Write((i + 1) + " ");

                                for (int j = 0; j < seans.Zal.ColumnCount; j++)
                                {
                                    bool sold = false;

                                    for (int k = 0; k < tickets.Length; k++)
                                    {
                                        if (tickets[k] != null && tickets[k].Seans.Id == id && tickets[k].Row == i && tickets[k].Column == j)
                                        {
                                            sold = true;
                                            break;
                                        }
                                    }

                                    if (sold)
                                        Console.Write("$ ");
                                    else
                                        Console.Write("* ");
                                }

                                Console.WriteLine("");
                            }

                            break;
                            case 2:
                            seansCheck = true;
                            break;
                        default:
                            seansCheck = true;
                            Console.WriteLine("Wrong Number!!");
                            break;
                    }
                    
                    if (seansCheck)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1.Buy Ticket:");
                        Console.WriteLine("2.Back: ");

                        int operation1 = int.Parse(Console.ReadLine());

                        switch (operation1)
                        {
                            case 1:
                                Console.Write("Select Seans: ");
                                var seansId = int.Parse(Console.ReadLine());
                                Console.Write("Select Row: ");
                                var row = int.Parse(Console.ReadLine());
                                Console.Write("Select Column: ");
                                var column = int.Parse(Console.ReadLine());

                                var seans = (Seans) seansManager.Get(seansId);

                                ticketManager.CreateTicket(seans, row - 1, column - 1);

                                break;
                            case 2:
                                break;
                            default:
                                Console.WriteLine("Wrong Number!!");
                                break;
                        }
                    }
                }

            } while (command.ToLower() != "quit");
        }
    }
}