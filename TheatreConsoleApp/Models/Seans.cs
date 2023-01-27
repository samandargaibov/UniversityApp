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
        internal Zal[] Zals { get; set; }

        internal DateTime SeansTime { get; set; }

        internal string[] Films { get; set; }

        public override string ToString()
        {
            string filmInfo = "";

            foreach (var item in Films)
            {
                if (item == null)
                    continue;

                filmInfo += item.ToString() + " ";
            }

            return $"Seans ID: {Id}, Zal: {Zals}, Seans Time: {SeansTime}, Films: {filmInfo} ";
        }
    }
}
