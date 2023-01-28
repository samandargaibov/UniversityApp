﻿using System;
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

            //return $"Zal ID: {Id}, Zal Name: {Name,-7}, Sira: {Row,-2}, Cerge: {Column,-2}";
            return $"{Name}";
        }
    }
}
