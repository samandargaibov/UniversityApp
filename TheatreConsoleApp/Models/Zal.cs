using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services;

namespace TheatreConsoleApp.Models
{
    internal class Zal : Entity
    {
        internal string Name { get; set; }

        internal int Row { get; set; }

        internal int Column { get; set; }

        public override string ToString()
        {
            string zalInfo = "";

            foreach (var item in Name)
            {
                if (item == null)
                    continue;

                zalInfo += item.ToString();
            }

            return $"Zal ID: {Id}, Zal Name: {zalInfo}, Sira: {Row}, Cerge: {Column}";
        }
    }
}
