using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services;

namespace TheatreConsoleApp.Models
{
    internal class Seans : Entity
    {
        internal Zal[] Zals { get; set; }

        internal DateTime SeansTime { get; set; }
    }
}
