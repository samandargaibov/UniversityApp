using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Core.Services;

namespace TheatreConsoleApp.Models
{
    internal class Kino : Entity
    {
        internal string[] FilmNames { get; set; }

        public override string ToString()
        {
            string movieInfo = "";

            foreach (var item in FilmNames)
            {
                if (item == null)
                    continue;

                movieInfo += item.ToString() + " ";
            }

            return $"Kino ID: {Id}, Kino Name: {movieInfo}";
        }
    }
}
