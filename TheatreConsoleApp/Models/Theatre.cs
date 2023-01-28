using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Core.Services;

namespace TheatreConsoleApp.Models
{
    internal class Theatre : Entity
    {
        internal string Name { get; set; }

        internal Zal[] Zals { get; set; }

        internal Film[] Films { get; set; } 

        internal Seans[] Seans { get; set; }

        public override string ToString()
        {
            string zalsInfo = "";
            string filmInfo = "";
            string seansInfo = "";

            foreach (var item in Zals)
            {
                if (item == null)
                    continue;

                zalsInfo += item.ToString() + " ";
            }

            foreach (var item in Films)
            {
                if (item == null)
                    continue;

                filmInfo += item.ToString() + "";
            }

            //foreach (var item in Seans)
            //{
            //    if (item == null)
            //        continue;

            //    seansInfo += item.ToString() + "";
            //}

            //return $"{Name}\nFilm: {filmInfo}\nSeans: {seansInfo}\nZal: {zalsInfo}";
            return $"{Name}\nFilm: {filmInfo}\nZal: {zalsInfo}";
        }
    }
}
