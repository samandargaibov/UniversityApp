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

        public override string ToString()
        {
            string zalsInfo = "";

            foreach (var item in Zals)
            {
                if (item == null)
                    continue;

                zalsInfo += item.ToString() + " ";
            }

            return $"Theatre ID: {Id}, Theatre Name: {Name},\nZals: {zalsInfo}";
        }
    }
}
