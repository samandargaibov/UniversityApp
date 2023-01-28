using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Core.Services;

namespace TheatreConsoleApp.Models
{
    internal class Seans : Entity
    {
        //internal Zal[] Zals { get; set; }

        internal DateTime SeansTime { get; set; }

        //internal Film[] Films { get; set; }

        internal Theatre[] Theatres { get; set; }

        internal int Price { get; set; } 

        public override string ToString()
        {
            string filmInfo = "";
            string zalInfo = "";
            string theatreInfo = "";

            //foreach (var item in Films)
            //{
            //    if (item == null)
            //        continue;

            //    filmInfo += item.ToString() + " ";
            //}

            //foreach (var item in Zals)
            //{
            //    if (item == null)
            //        continue;

            //    zalInfo += item.ToString() + " ";
            //}

            foreach (var item in Theatres)
            {
                if (item == null)
                    continue;

                theatreInfo += item.ToString() + " ";
            }

           // return $"Seans ID: {Id}\nFilm: {filmInfo}\nSeans: {SeansTime}\nKinoteatr: {theatreInfo}\nPrice: {Price} AZN\n";
            return $"Seans ID: {Id}\nSeans: {SeansTime}\nKinoteatr: {theatreInfo}\nPrice: {Price} AZN\n";
        }
    }
}
