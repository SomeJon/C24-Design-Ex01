﻿using FetchHandler.Fetch.WarrperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchHandler.Fetch.About
{
    public class AboutDataWarpper
    {
        public string Birthday { get; set; }
        public LocationObject Location { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Hometown Hometown { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
