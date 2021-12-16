using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPLab_2.Models;
using ASPLab_2.ViewModels;

namespace ASPLab_2.Controllers
{
    public class HomeController : Controller
    {
        //private List<Services> _services;
        //private List<TestTimonal> _testTimonals;
        private DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;

            //_testTimonals = new List<TestTimonal>
            //{
            //    new TestTimonal{Id =1, Fullname="Sara Wilsson",Img="http://localhost:14707/assets/img/testimonials/testimonials-2.jpg",Position="Designer",Describ="Export tempor illum tamen malis malis eram quae irure esse labore quem cillum quid cillum eram malis quorum velit fore eram velit sunt aliqua noster fugiat irure amet legam anim culpa."},
            //    new TestTimonal{Id =2, Fullname="Matt Brandon ",Img="http://localhost:14707/assets/img/testimonials/testimonials-2.jpg",Position="Freelancer",Describ="Fugiat enim eram quae cillum dolore dolor amet nulla culpa multos export minim fugiat minim velit minim dolor enim duis veniam ipsum anim magna sunt elit fore quem dolore labore illum veniam."},
            //    new TestTimonal{Id =3, Fullname="Jena Karlis",Img="http://localhost:14707/assets/img/testimonials/testimonials-2.jpg",Position="Store Owner",Describ="Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim."},
            //    new TestTimonal{Id =4, Fullname="John Larson ",Img="http://localhost:14707/assets/img/testimonials/testimonials-2.jpg",Position="Entrepreneur",Describ="Quis quorum aliqua sint quem legam fore sunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid."},

            //};
            // _services = new List<Services>
            //{
            //    new Services{Id=1,Icon = "bx bxl-dribbble",Title = "Lorem supra ",Subtitle= "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            //    new Services{Id=2,Icon = "bx bx-file",Title = "Sed ut perspiciatis ",Subtitle= "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
            //    new Services{Id=3,Icon = "bx bx-tachometer",Title = "Magni Dolores",Subtitle= "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
            //    new Services{Id=4,Icon = "bx bx-world",Title = "Nemo Enim ",Subtitle= "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
            //};
        }

        public IActionResult Index()
        {
            HomeViewModel homevm = new HomeViewModel
            {
                Services = _context.Services.ToList(),
                testTimonals = _context.TestTimonals.ToList(),
                Clients = _context.Clients.ToList(),
                aboutUs = _context.aboutUs.ToList(),
            };


            return View(homevm);
        }
        
    }
}
