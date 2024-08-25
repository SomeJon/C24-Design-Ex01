using FacebookWrapper.ObjectModel;
using FetchHandler.Fetch.WarrperClasses;
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
        public City Location { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public City Hometown { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
