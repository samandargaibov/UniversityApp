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
        internal Zal Zal { get; set; }

        internal DateTime SeansTime { get; set; }

        internal Film Film { get; set; }

        internal int Price { get; set; } 

        public override string ToString()
        {
            return $"Seans ID: {Id}\nSeans: {SeansTime}\n{Film}\n{Zal}\nPrice: {Price} AZN\n";
        }
    }
}
