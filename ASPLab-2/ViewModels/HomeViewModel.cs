using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPLab_2.Models;

namespace ASPLab_2.ViewModels
{
    public class HomeViewModel
    {
        public List<Services> Services { get; set; }
        public List<TestTimonal> testTimonals { get; set; }
        public List<Client> Clients { get; set; }
        public List<AboutUs> aboutUs { get; set; }

    }
}
